using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05LabExer1_EventDriven_
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
        public static string FileName;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] Info = { "Student No. " + txtStudent.Text,
                               "Full Name: " + txtLname.Text +", "+ txtFname.Text +", "+ txtMi.Text+".",
                               "Program: " + cbProgram.Text,
                               "Gender: " + cbGender.Text,
                               "Age: " + txtAge.Text,
                               "Birthday: " + dtBday.Value.Date,
                               "Contact No. " + txtContactnum.Text};

            FileName = txtStudent.Text + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FileName)))
            {
                foreach (string s in Info)
                {
                    outputFile.WriteLine(s);
                    Console.WriteLine(s);
                }
            }
            MessageBox.Show("Created");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.Show();

            this.Close();
        }
    }
}
