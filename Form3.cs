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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            DatabaseDriver databaseDriver = new DatabaseDriver();
            var item_Id = MongoDB.Bson.ObjectId.Parse(teamId.Text);
            Console.WriteLine(databaseDriver.GetSpecificTeam(item_Id));
        }  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teamText_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
