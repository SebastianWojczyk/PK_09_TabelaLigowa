using System;
using System.Linq;
using System.Windows.Forms;

namespace PK_09_TabelaLigowa
{
    public partial class Form1 : Form
    {
        DataClassesSportDataContext DatabaseDC = new DataClassesSportDataContext();
        public Form1()
        {
            InitializeComponent();

            DrawList();
        }
        private void DrawList()
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(new UserControlTeam());
            int num = 1;
            foreach (Team t in DatabaseDC.Teams.AsEnumerable().OrderByDescending(x => x.ScoreSum))
            {
                UserControlTeam uct = new UserControlTeam(num++, t);
                flowLayoutPanel.Controls.Add(uct);
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            FormTeam ft = new FormTeam();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                DatabaseDC.Teams.InsertOnSubmit(ft.MyTeam);
                DatabaseDC.SubmitChanges();
            }
            DrawList();
        }

        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            FormMatch fm = new FormMatch(DatabaseDC.Teams.ToArray());
            if (fm.ShowDialog() == DialogResult.OK)
            {
                DatabaseDC.Matches.InsertOnSubmit(fm.MyMatch);
                DatabaseDC.SubmitChanges();
            }
            DrawList();
        }
    }
}
/*
CREATE TABLE [dbo].[Team] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Match] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [TeamHostId]  INT NOT NULL,
    [TeamGuestId] INT NOT NULL,
    [GoalHost]    INT NOT NULL,
    [GoalGuest]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Match_TeamHost] FOREIGN KEY ([TeamHostId]) REFERENCES [dbo].[Team] ([Id]),
    CONSTRAINT [FK_Match_TeamGuest] FOREIGN KEY ([TeamGuestId]) REFERENCES [dbo].[Team] ([Id]),
    CONSTRAINT [CK_Match_HostGuest] CHECK ([TeamHostId]<>[TeamGuestId])
);
 */