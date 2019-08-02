﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAGrim.UI.Filters {
    public partial class Misc : UserControl {
        public Misc() {
            InitializeComponent();
        }

        public void Misc_Load(object sender, EventArgs e) {
            miscPanel.ToggleState();
        }

        public bool SocketedOnly => cbSocketed.Checked;
        public bool DuplicatesOnly => cbDuplicates.Checked;
        public bool PetBonuses => cbPetBonuses.Checked;
        public bool RecentOnly => cbRecentOnly.Checked;

        public List<string[]> Filters {
            get {
                var filters = new List<string[]>();

                if (setbonus.Checked) {
                    filters.Add(new[] { "setName", "itemSetName" });
                }

                if (shieldStuff.Checked) {
                    filters.Add(new[]
                    {
                        "blockAbsorption", "defensiveBlock", "defensiveBlockChance", "defensiveBlockModifier",
                        "defensiveBlockAmountModifier"
                    });
                }

                if (cbAttackSpeed.Checked) {
                    filters.Add(new[]
                        {"characterAttackSpeedModifier", "characterAttackSpeed", "characterTotalSpeedModifier"});
                }

                if (cbCastspeed.Checked) {
                    filters.Add(new[] {"characterSpellCastSpeedModifier", "characterTotalSpeedModifier"});
                }

                if (cbRunspeed.Checked) {
                    filters.Add(new[] {"characterRunSpeedModifier", "characterTotalSpeedModifier"});
                }

                if (exp.Checked) {
                    filters.Add(new[] {"characterIncreasedExperience"});
                }

                if (cbReflect.Checked) {
                    filters.Add(new[] {"defensiveReflect"});
                }

                if (health.Checked) {
                    filters.Add(new[] {"characterLifeModifier", "characterLife"});
                }

                if (cbDefense.Checked) {
                    filters.Add(new[] {"characterDefensiveAbilityModifier", "characterDefensiveAbility"});
                }

                if (cbOffensive.Checked) {
                    filters.Add(new[] {"characterOffensiveAbility", "characterOffensiveAbilityModifier"});
                }

                if (cbMasterySkills.Checked) {
                    filters.Add(new[] {"augmentMastery1", "augmentMastery2"});
                }

                if (cbPetBonuses.Checked) {
                    filters.Add(new[] {"petBonusName"});
                }

                return filters;
            }
        }
    }
}