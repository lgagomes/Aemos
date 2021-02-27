using Aemos.CharacterClasses;
using Aemos.DomainClasses;
using Aemos.DomainClasses.DTOs;
using Aemos.Helpers;
using Aemos.Repository.Creators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Aemos.Repository
{
    public class SpellsRepository
    {
        private readonly string _connectionString = Properties.Settings.Default.SpellsConnectionString;
        private readonly int _maxSpellCycle = 9;

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

        public List<SpellDTO> GetSpells(SpellFIlter spellFilter)
        {
            List<SpellDTO> spells = new List<SpellDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
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

                        SqlCommand sqlCommand = new SqlCommand(query, connection);
                        sqlCommand.Parameters.AddWithValue("@IdClass", spellFilter.IdClass);
                        sqlCommand.Parameters.AddWithValue("@ClassLevel", spellFilter.SpellLevel);
                        sqlCommand.Parameters.AddWithValue("@IdDomain", spellFilter.IdDomain);
                        sqlCommand.Parameters.AddWithValue("@SpellName", $"%{spellFilter.SpellName}%");
                        sqlCommand.Parameters.AddWithValue("@IdSchool", spellFilter.IdSchool);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                spells.Add(SpellDetailedCreator.GetSpellDetailed(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }
            return spells;
        }       

        public List<BaseClass> GetSpellcastingClasses()
        {
            var spellcasters = new List<BaseClass>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = Resources.SpellResources.GetSpellcastingClasses;
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                spellcasters.Add(ClassCreator.GetSpellcaster(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }

            return spellcasters;
        }

        public List<SpellSchool> GetSpellSchools()
        {
            var schools = new List<SpellSchool>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = Resources.SpellResources.GetSpellSchools;
                        SqlCommand sqlCommand = new SqlCommand(query, connection);
                        
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                schools.Add(SchoolCreator.GetSchool(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }

            return schools;
        }

        public List<SpellDomain> GetSpellDomains()
        {
            var domais = new List<SpellDomain>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = Resources.SpellResources.GetSpellDomains;
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                domais.Add(SpellDomainCreator.GetDomain(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }

            return domais;
        }
    }
}
