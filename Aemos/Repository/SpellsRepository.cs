using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Aemos.Repository
{
    public static class SpellsRepository
    {
        public static int[] GetSpellsSlots(string className, int characterLevel, int maxSpellCycle, string tableComplement)
        {
            int[] spellSlots = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            try
            {
                string connectionString = Properties.Settings.Default.SpellsConnectionString;
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

        public static List<SpellDTO> GetSpellsDetailed(SpellFIlter spellFIlter)
        {
            List<SpellDTO> spellsDetailed = new List<SpellDTO>();
            try
            {
                string connectionString = Properties.Settings.Default.SpellsConnectionString;                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        StringBuilder query = new StringBuilder($"{Resources.SpellResources.GetSpellsDetailed}");
                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);

                        sqlCommand.Parameters.AddWithValue("@Name", $"%{spellFIlter.SpellName}%");

                        if (!string.IsNullOrWhiteSpace(spellFIlter.ClassLevel))
                        {
                            sqlCommand.Parameters.AddWithValue("@Level", $"%{spellFIlter.ClassName} {spellFIlter.ClassLevel}%");
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Level", $"%{spellFIlter.ClassName}%");
                        }

                        sqlCommand.Parameters.AddWithValue("@School", $"%{spellFIlter.SpellSchool}%");

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
