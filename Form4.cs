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
    public partial class Form4 : Form
    {
        public Form4()
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
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var driver = new DatabaseDriver();
            var updateTeam = new TeamModel() { League = league.Text, NumberOfPlayers = Int32.Parse(numPlayers.Text), TeamName = teamText.Text };
            Console.WriteLine(driver.Update(updateTeam));

        }

        private void numPlayers_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void teamText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
