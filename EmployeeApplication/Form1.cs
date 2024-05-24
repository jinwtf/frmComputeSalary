using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        private PartTimeEmployee partTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = this.textBox1.Text;
            string LastName = this.textBox2.Text;
            string Department = this.textBox3.Text;
            string JobTitle = this.textBox4.Text;
            int hoursWorked = Convert.ToInt32(textBox5.Text);
            int totalhoursWorked = Convert.ToInt32(textBox6.Text);

            partTime = new PartTimeEmployee(FirstName, LastName, Department, JobTitle);
            partTime.computeSalary(hoursWorked, totalhoursWorked);
            label8.Text = partTime.FirstName;
            label10.Text = partTime.LastName;
            label12.Text = Convert.ToString(partTime.getSalary());

        }
    }
    }
