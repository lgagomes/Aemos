using System;
using System.Data.SqlClient;

namespace Aemos.Helpers
{
    public static class SpellDetailedCreator
    {
        public static SpellDTO GetSpellDetailed(SqlDataReader reader)
        {
            return new SpellDTO
            {
                Name = (reader["Name"] == DBNull.Value) ? string.Empty : (string)reader["Name"],
                School = (reader["School"] == DBNull.Value) ? string.Empty : (string)reader["School"],
                SubSchool = (reader["SubSchool"] == DBNull.Value) ? string.Empty : (string)reader["SubSchool"],
                Descriptor = (reader["Descriptor"] == DBNull.Value) ? string.Empty : (string)reader["Descriptor"],
                Level = (reader["Level"] == DBNull.Value) ? string.Empty : (string)reader["Level"],
                Components = (reader["Components"] == DBNull.Value) ? string.Empty : (string)reader["Components"],
                CastingTime = (reader["CastingTime"] == DBNull.Value) ? string.Empty : (string)reader["CastingTime"],
                Range = (reader["Range"] == DBNull.Value) ? string.Empty : (string)reader["Range"],
                Target = (reader["Target"] == DBNull.Value) ? string.Empty : (string)reader["Target"],
                Effect = (reader["Effect"] == DBNull.Value) ? string.Empty : (string)reader["Effect"],
                Area = (reader["Area"] == DBNull.Value) ? string.Empty : (string)reader["Area"],
                Duration = (reader["Duration"] == DBNull.Value) ? string.Empty : (string)reader["Duration"],
                SavingThrow = (reader["SavingThrow"] == DBNull.Value) ? string.Empty : (string)reader["SavingThrow"],
                SpellResistance = (reader["SpellResistance"] == DBNull.Value) ? string.Empty : (string)reader["SpellResistance"],
                BriefDescription = (reader["BriefDescription"] == DBNull.Value) ? string.Empty : (string)reader["BriefDescription"],
                MaterialComponents = (reader["MaterialComponents"] == DBNull.Value) ? string.Empty : (string)reader["MaterialComponents"],
                ArcaneMaterialComponents = (reader["ArcaneMaterialComponents"] == DBNull.Value) ? string.Empty : (string)reader["ArcaneMaterialComponents"],
                XpCost = (reader["XpCost"] == DBNull.Value) ? string.Empty : (string)reader["XpCost"],
                Focus = (reader["Focus"] == DBNull.Value) ? string.Empty : (string)reader["Focus"],
                ArcaneFocus = (reader["ArcaneFocus"] == DBNull.Value) ? string.Empty : (string)reader["ArcaneFocus"],
                BardFocus = (reader["BardFocus"] == DBNull.Value) ? string.Empty : (string)reader["BardFocus"],
                ClericFocus = (reader["ClericFocus"] == DBNull.Value) ? string.Empty : (string)reader["ClericFocus"],
                DruidFocus = (reader["DruidFocus"] == DBNull.Value) ? string.Empty : (string)reader["DruidFocus"],
                SorcererFocus = (reader["SorcererFocus"] == DBNull.Value) ? string.Empty : (string)reader["SorcererFocus"],
                WizardFocus = (reader["WizardFocus"] == DBNull.Value) ? string.Empty : (string)reader["WizardFocus"],
            };
        }
    }
}
