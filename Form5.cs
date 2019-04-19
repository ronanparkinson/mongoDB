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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var driver = new DatabaseDriver();
            var deleteTeam = MongoDB.Bson.ObjectId.Parse(teamId.Text);
            Console.WriteLine(driver.Delete((deleteTeam)));

        }
    }
}