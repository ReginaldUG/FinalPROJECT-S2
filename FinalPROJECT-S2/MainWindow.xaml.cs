using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalPROJECT_S2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        MyAPIFoootballDataEntities db = new MyAPIFoootballDataEntities();

        public MainWindow()
        {
            InitializeComponent();
        }
        string[] testLeagueschoice = { "La Liga", "Premier League", "Serie A", "Ligue 1" };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            //Setting the Itemsource for the Seasons choice Display   
            string[] testSeasons = { "2021/2022" };

            List<string> Seasons = new List<string>();
            foreach (string seasondates in testSeasons)
            {
                Seasons.Add(seasondates);
            }
            ComboBoxDisplaySeason.ItemsSource = Seasons;
            //WORKS

            //Setting the League choice selector
            
            List<string> LeagueChoice = new List<string>();
            foreach (string leaguechoices in testLeagueschoice)
            {
                LeagueChoice.Add(leaguechoices);
            }
            LstBoxLeagueChoice.ItemsSource = LeagueChoice;
            //WORKS
        }

        //When the Button is clicked
        private void BtnDisplayTable_Click(object sender, RoutedEventArgs e)
        {
            //Decision to display the data grid
            if (ComboBoxDisplaySeason.SelectedItem != null && LstBoxLeagueChoice.SelectedItem != null)
            {
                string chosenleague = LstBoxLeagueChoice.SelectedItem.ToString();
             

                var query = from s in db.Standings
                            join l in db.Leagues on s.Leagues_LeagueID equals l.LeagueID
                            where l.LeagueName == chosenleague
                            orderby s.StandingsID ascending
                            select new {Club = s.Team.TeamName, Win=s.Won,Draw = s.Draw,Loss=s.Loss, GA=s.GoalsAgainst,GD=s.GoalsDiff, Points = s.Points };

                DataGridLeagueTable.ItemsSource = query.ToList();
            }
            
        }

       
    }
}
