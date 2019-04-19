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
    public partial class Form1 : Form
    {
        public Form1()
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

          // var addTeam = new TeamModel(){League = "A", NumberOfPlayers = 22, TeamName = "Hasks"};
          // Console.WriteLine(driver.Create(addTeam));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Add Team"))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

            else if (comboBox1.Text.Equals("Get Team"))
            {
                Form3 form3 = new Form3();
                form3.Show();
            }

            else if (comboBox1.Text.Equals("Update Team"))
            {
                Form4 form4 = new Form4();
                form4.Show();
            }

            else
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
        }
    }
}
