using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_09_TabelaLigowa
{
    public partial class FormMatch : Form
    {
        public Match MyMatch { get; internal set; }
        public FormMatch(Team [] teams)
        {
            InitializeComponent();
            MyMatch = new Match();

            listBoxTeamHost.Items.AddRange(teams);
            listBoxTeamGuest.Items.AddRange(teams);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MyMatch.TeamHost = listBoxTeamHost.SelectedItem as Team;
            MyMatch.TeamGuest = listBoxTeamGuest.SelectedItem as Team;

            MyMatch.GoalHost = (int)numericUpDownGoalHost.Value;
            MyMatch.GoalGuest = (int)numericUpDownGoalGuest.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
