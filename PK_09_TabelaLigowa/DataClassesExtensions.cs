using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_09_TabelaLigowa
{
    partial class Team
    {
        public EntitySet<Match> MatchesGuest
        {
            get
            {
                return Matches;
            }
        }
        public EntitySet<Match> MatchesHost
        {
            get
            {
                return Matches1;
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public int GoalScoredHostSum
        {
            get => this.MatchesHost.Sum(m => m.GoalHost);
        }
        public int GoalScoredGuestSum
        {
            get => this.MatchesGuest.Sum(m => m.GoalGuest);
        }
        public int GoalScoredSum
        {
            get => this.GoalScoredHostSum + this.GoalScoredGuestSum;
        }
        public int GoalLostHostSum
        {
            get => this.MatchesHost.Sum(m => m.GoalGuest);
        }
        public int GoalLostGuestSum
        {
            get => this.MatchesGuest.Sum(m => m.GoalHost);
        }
        public int GoalLostSum
        {
            get => this.GoalLostHostSum + this.GoalLostGuestSum;
        }

        public int ScoreHostSum
        {
            get => this.MatchesHost.Sum(m => m.ScoreHost);
        }
        public int ScoreGuestSum
        {
            get => this.MatchesGuest.Sum(m => m.ScoreGuest);
        }
        public int ScoreSum
        {
            get => this.ScoreHostSum + this.ScoreGuestSum;
        }
    }
    partial class Match
    {
        public Team TeamGuest
        {
            get
            {
                return Team;
            }
            set
            {
                Team = value;
            }

        }
        public Team TeamHost
        {
            get
            {
                return Team1;
            }
            set
            {
                Team1 = value;
            }
        }
        public int ScoreHost
        {
            get
            {
                if (GoalHost > GoalGuest)
                {
                    return 3;
                }
                else if (GoalHost < GoalGuest)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        public int ScoreGuest
        {
            get
            {
                if (GoalGuest > GoalHost)
                {
                    return 3;
                }
                else if (GoalGuest < GoalHost)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

