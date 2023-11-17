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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show();

            this.Close();
        }

        public string path;
        private void button2_Click(object sender, EventArgs e)
        {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                path = openFileDialog1.FileName;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        SRlv.Items.Add(_getText);
                    }
                }
            }
                
            }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            SRlv.Clear();
        }
    }
}
