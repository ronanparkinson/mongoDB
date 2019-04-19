using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoPortfolio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var driver = new DatabaseDriver();

            var test = driver.GetAllTeams();

            foreach (var team in test)
            {
                Console.WriteLine(team._id);
                Console.WriteLine(team.TeamName);
                Console.WriteLine(team.NumberOfPlayers);
                Console.WriteLine(team.League);
            }

            //var addTeam = new TeamModel() { League = "A", NumberOfPlayers = 22, TeamName = "Hasks" };
            //Console.WriteLine(driver.Create(addTeam));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void addbutton_Click(object sender, EventArgs e)
        {
            var driver = new DatabaseDriver();
            var addTeam = new TeamModel() { League = leaguetext.Text, NumberOfPlayers = Int32.Parse(numplayerstext.Text), TeamName = teamnametext.Text };
            Console.WriteLine(driver.Create(addTeam));         
        }
    }
}
