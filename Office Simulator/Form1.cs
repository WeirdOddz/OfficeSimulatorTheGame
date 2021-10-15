using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Simulator
{
    public partial class Form1 : Form
    {
        int cash = 5000;
        int cash_click = 1000;
        string employee1_nam = "";
        string employee2_nam = "";
        int employee1_addition = 0;
        int employee2_addition = 0;
        int employees = 0;
        bool employee1hired = false;
        bool employee2hired = false;
        int employee1_cost = 0;
        int employee2_cost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void currentCash_Click(object sender, EventArgs e)
        {
            currentCash.Text = "cash: " + (cash).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mark_icon_basicoffice_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            progressBar1.Value = 0;
            cash = cash + random.Next(-250, cash_click);
            progressBar1.Value = 100;
        }

        private void mark_basicOffice_Click(object sender, EventArgs e)
        {
            mark_icon_basicoffice.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] organicArrayOfYourLocalNames =
            {
                "Amy",
                "James",
                "Oscar",
                "Tim",
                "Keanu",
                "John",
                "Jason",
                "Annika",
                "Smith",
                "Will",
                "Liam",
                "Olivia",
                "Oliver",
                "Elijah",
                "Sophia",
                "Programming makes me depressed",
                "William",
                "Benjamin"
            };
            employee_1.Visible = true;
            employee_2.Visible = true;
            string employee_1displayNam = organicArrayOfYourLocalNames[rand.Next(1, 18)];
            string employee_2displayNam = organicArrayOfYourLocalNames[rand.Next(1, 18)];
            employee1_cost = rand.Next(300, 12000);
            employee2_cost = rand.Next(300, 12000);
            employee2hired = false;
            employee1hired = false;
            employee1_addition = rand.Next(0 - employees, 1000 + rand.Next(300, 7500) + rand.Next(300, 3000));
            employee2_addition = rand.Next(0 - employees, 1000 + rand.Next(300, 7500) + rand.Next(300, 3000));
            employee_1.Text = employee_1displayNam + " (Cost: " + (employee1_cost).ToString() + "; Cash Increase: " + (employee1_addition).ToString() + ")";
            employee_2.Text = employee_2displayNam + " (Cost: " + (employee2_cost).ToString() + "; Cash Increase: " + (employee2_addition).ToString() + ")";
        }

        private void employee_2_Click(object sender, EventArgs e)
        {
            if (employee2hired == false)
            {
                employee2hired = true;
                cash = cash - employee2_cost;
                cash_click = cash_click + employee2_addition;
            }
        }

        private void employee_1_Click(object sender, EventArgs e)
        {
            if (employee1hired == false)
            {
                employee1hired = true;
                cash = cash - employee1_cost;
                cash_click = cash_click + employee1_addition;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
