//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalPROJECT_S2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Standing
    {
        public int StandingsID { get; set; }
        public int MatchesPlayed { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Loss { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDiff { get; set; }
        public int Points { get; set; }
        public Nullable<int> Leagues_LeagueID { get; set; }
        public Nullable<int> Team_TeamID { get; set; }
    
        public virtual League League { get; set; }
        public virtual Team Team { get; set; }
    }
}
