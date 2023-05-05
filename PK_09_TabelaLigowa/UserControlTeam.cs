using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_09_TabelaLigowa
{
    public partial class UserControlTeam : UserControl
    {
        public UserControlTeam()
        {
            InitializeComponent();
        }
        public UserControlTeam(int num, Team t)
        {
            InitializeComponent();
            labelNumber.Text = num.ToString();
            labelName.Text = t.Name;
            labelGoalsScored.Text = t.GoalScoredSum.ToString();
            labelGoalsLost.Text = t.GoalLostSum.ToString();
            labelScore.Text = t.ScoreSum.ToString();
        }
    }
}
