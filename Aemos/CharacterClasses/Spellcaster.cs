﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace Aemos.CharacterClasses
{
    public class Spellcaster : BaseClass
    {
        public int MaxSpellCycle { get; set; }
        public string KeyAttribute { get; set; }
        public decimal KeyAttributeModifier { get; set; }
        public int[] SpellsDC { get; set; }
        public decimal[] ExtraSpells { get; set; }
        public int[,] DailySpells { get; set; }
        public int FirstDC { get; set; }

        public Spellcaster()
        {
            SpellsDC = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            ExtraSpells = new decimal[10] { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }; ;
            DailySpells = new int[20, 10];
            KeyAttributeModifier = 0;
            InitializeDailySpells();
        }

        public void InitializeDailySpells()
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 10; j++)
                    DailySpells[i, j] = -1;
        }

        public void GetSpellsPerDay()
        {
            try
            {
                using(DataSet ds = new DataSet())
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create(ClassName + "_daily_spells.xml", new XmlReaderSettings());
                    ds.ReadXml(xmlFile);

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < MaxSpellCycle; j++)
                        {
                            int.TryParse(ds.Tables[0].Rows[i].ItemArray[j].ToString(), out int value);
                            DailySpells[i, j] = value;
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetExtraSpells()
        {
            for (int i = 1; i < MaxSpellCycle; i++)
                ExtraSpells[i] = Math.Ceiling((KeyAttributeModifier - (i - 1)) / 4);
        }

        public void GetSpellsDC()
        {
            for (int i = FirstDC; i < MaxSpellCycle; i++)
                SpellsDC[i] = 10 + (int)KeyAttributeModifier + i;
        }

        public bool CastSpell(int charLevel, int spellCycle)
        {
            if (DailySpells[charLevel - 1, spellCycle] > 0)
            {
                DailySpells[charLevel - 1, spellCycle]--;
                return true;
            }
            else
                return false;                   
        }
    }
}
