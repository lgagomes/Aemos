using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Aemos.Repository
{
    public static class SpellsRepository
    {
        private static string connectionString = Properties.Settings.Default.SpellsConnectionString;

        public static int[] GetSpellsSlots(string className, int characterLevel, int maxSpellCycle, string tableComplement)
        {
            int[] spellSlots = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            try
            {                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        using (var sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = connection;
                            sqlCommand.CommandText = 
                                    $"SELECT * " +
                                    $"FROM {className}{tableComplement} " +
                                    $"WHERE {className}{tableComplement}.Id = {characterLevel}";

                            using (var reader = sqlCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    for (int i = 0; i < maxSpellCycle; i++)
                                    {
                                        spellSlots[i] = (int)reader["Level" + i];
                                    }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = $"{Resources.SpellResources.GetSpellsDetailed}";
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        sqlCommand.Parameters.AddWithValue("@Name", $"%{spellFilter.SpellName}%");

                        if (!string.IsNullOrWhiteSpace(spellFilter.ClassLevel))
                        {
                            sqlCommand.Parameters.AddWithValue("@Level", $"%{spellFilter.ClassName} {spellFilter.ClassLevel}%");
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Level", $"%{spellFilter.ClassName}%");
                        }

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
            catch(Exception ex)
            {
                WarningMessage.ShowWarningMessage(ex.Message);
            }
            return spellsDetailed;
        }
    }
}
