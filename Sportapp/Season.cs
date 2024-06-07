using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Sportapp
{
    public class Season
    {
        private int year;
        private string sportType;
        private string league;
        private Round[] roundsAmount;
        private Round[] nextRound;
        private Team[] teamInSeason;
        private int teamsNumber;
        private bool stillActive;

        public Season(int year, string sportType, string league, Team[] teams)
        {
            this.year = year;
            this.sportType = sportType;
            this.league = league;
            this.teamInSeason = teams;

        }


        public void DisplayTable()
        {
            Console.WriteLine("Tabel of Teams and Points");
            foreach(Team t in teamInSeason)
            {
                Console.WriteLine("Name of team: " +t.getName() + "points: " +t.getPoints());
            }
        }
    }
}
