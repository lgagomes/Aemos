using Aemos.CharacterClasses;
using Aemos.DomainClasses;
using Aemos.DomainClasses.DTOs;
using Aemos.Helpers;
using Aemos.Repository.DapperAbstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Aemos.Repository
{
    public class SpellsRepository
    {
        private readonly string _connectionString = Properties.Settings.Default.SpellsConnectionString;
        private readonly int _maxSpellCycle = 9;
        private IDapperAbstraction dapperAbstraction;

        public int[] GetSpellsSlots(string className, int characterLevel, string tableComplement)
        {
            int[] spellSlots = new int[10];

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = Resources.SpellResources.GetSpellsSlots;
                        string tableName = $"{className}{tableComplement}";

                        SqlCommand sqlCommand = new SqlCommand(query.Replace("@TableName", tableName), connection);
                        sqlCommand.Parameters.AddWithValue("@CharacterLevel", characterLevel);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i <= _maxSpellCycle; i++)
                                {
                                    spellSlots[i] = (int)reader["Level" + i];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }
            return spellSlots;
        }        

        public SpellsRepository()
        {
            dapperAbstraction = new DapperAbstraction.DapperAbstraction(Properties.Settings.Default.SpellsConnectionString);
        }

        public List<SpellDTO> GetSpells(SpellFIlter spellFilter)
        {
            var query = Resources.SpellResources.GetSpells;

            var whereFilter = new StringBuilder()
                .AppendLine(spellFilter.IdClass > 0 ? "AND ClassSpells.IdClass = @IdClass" : string.Empty)
                .AppendLine(spellFilter.SpellLevel > 0 ? "AND ClassSpells.ClassLevel = @ClassLevel" : string.Empty)
                .AppendLine(spellFilter.IdDomain > 0 ? "AND DomainSpells.IdDomain = @IdDomain" : string.Empty)
                .AppendLine(!string.IsNullOrWhiteSpace(spellFilter.SpellName) ? "AND SpellsCompendium.Name LIKE @SpellName" : string.Empty)
                .AppendLine(spellFilter.IdSchool > 0 ? "AND SchoolSpells.IdSchool = @IdSchool" : string.Empty)
                .ToString();

            if (!string.IsNullOrWhiteSpace(whereFilter))
            {
                query = query.Replace("--@Filter", whereFilter);
            }

            return dapperAbstraction.Query<SpellDTO>(query, 
                new
                {
                    spellFilter.IdClass,
                    ClassLevel = spellFilter.SpellLevel,
                    spellFilter.IdDomain,
                    SpellName = $"%{ spellFilter.SpellName}%",
                    spellFilter.IdSchool
                })
                .ToList();
        }

        public List<BaseClass> GetSpellcastingClasses() => 
            dapperAbstraction.Query<BaseClass>(Resources.SpellResources.GetSpellcastingClasses).ToList();

        public List<SpellSchool> GetSpellSchools() => 
            dapperAbstraction.Query<SpellSchool>(Resources.SpellResources.GetSpellSchools).ToList();

        public List<SpellDomain> GetSpellDomains() => 
            dapperAbstraction.Query<SpellDomain>(Resources.SpellResources.GetSpellDomains).ToList();
    }
}