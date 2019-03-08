using Aemos.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Aemos.Repository
{
    public static class SpellsRepository
    {
        public static int[] GetSpellsPerDay(string className, int characterLevel, int maxSpellCycle)
        {
            int[] spells = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

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
                            string classNameTable = FormatClassName(className);
                            sqlCommand.Connection = connection;
                            sqlCommand.CommandText = 
                                    $"SELECT * " +
                                    $"FROM {classNameTable}DailySpells " +
                                    $"WHERE {classNameTable}DailySpells.Id = {characterLevel}";

                            using (var reader = sqlCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    for (int i = 0; i < maxSpellCycle; i++)
                                    {
                                        spells[i] = (int)reader["Level" + i];
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
            return spells;
        }

        private static string FormatClassName(string className)
        {
            return $"{className.First().ToString().ToUpper()}{className.Substring(1)}";
        }
    }
}
