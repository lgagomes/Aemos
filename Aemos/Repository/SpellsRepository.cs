using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Aemos.Repository
{
    public static class SpellsRepository
    {
        private static readonly string _connectionString = Properties.Settings.Default.SpellsConnectionString;
        private static readonly int _maxSpellCycle = 9;
        private static string _spellLevelParameter;

        public static int[] GetSpellsSlots(string className, int characterLevel, string tableComplement)
        {
            int[] spellSlots = new int[10];

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = $"{Resources.SpellResources.GetSpellsSlots}";
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

        public static List<SpellDTO> GetSpellsDetailed(SpellFIlter spellFilter)
        {
            List<SpellDTO> spellsDetailed = new List<SpellDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = $"{Resources.SpellResources.GetSpellsDetailed}";
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        GetSpellLevelCommandParameters(spellFilter);
                        sqlCommand.Parameters.AddWithValue("@Name", $"%{spellFilter.SpellName}%");
                        sqlCommand.Parameters.AddWithValue("@Level", _spellLevelParameter);
                        sqlCommand.Parameters.AddWithValue("@School", $"%{spellFilter.SpellSchool}%");

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                spellsDetailed.Add(SpellDetailedCreator.GetSpellDetailed(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }
            return spellsDetailed;
        }

        private static void GetSpellLevelCommandParameters(SpellFIlter spellFilter)
        {
            if (string.Equals(spellFilter.ClassName, "Sorcerer") || string.Equals(spellFilter.ClassName, "Wizard"))
            {
                spellFilter.ClassName = "Sorcerer/Wizard";
            }

            _spellLevelParameter = (!string.IsNullOrWhiteSpace(spellFilter.ClassLevel))
                ? _spellLevelParameter = $"%{spellFilter.ClassName} {spellFilter.ClassLevel}%"
                : _spellLevelParameter = $"%{spellFilter.ClassName}%";
        }
    }
}
