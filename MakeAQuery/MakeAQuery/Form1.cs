using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeAQuery
{
    public partial class Form1 : Form
    {
        public List<string> inputItems = new List<string>();
        public List<string> outItems = new List<string>();
     
        public Form1()
        {
            InitializeComponent();

        }
        public void WhereClause()
        {
            int counter = 0;
            string line;
          
            // Read the file and display it line by line.
            System.IO.StreamReader file =
            new System.IO.StreamReader("c:\\Users\\highfever666\\Documents\\inputData.txt");
            while ((line = file.ReadLine()) != null)
            {
                    inputItems.Add(line);
                    outItems.Add("'" + line + "'" + ",");
                    counter++;
                
                file.Close();

                inputBox.DataSource = inputItems;
                outputBox.DataSource = outItems;
                MainScreen frm = new MainScreen(outputBox.Text);
                frm.ShowDialog();
                frm.Close();
            }
            }
      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WhereClause();
            }
            catch
            {
                MessageBox.Show("An Error Occured When Openning Your Input Folder For Where Clause Additons! Please Check The File And Try Again \r\b" + "OR You Closed The Last Window");
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
           System.IO.StreamWriter saveFile =
               new System.IO.StreamWriter("c:\\Users\\highfever666\\Documents\\outputData.txt");
           foreach (string line in outItems)
               saveFile.WriteLine(line);
           saveFile.Close();
        }

        private void MSQLWhereInBTN_Click(object sender, EventArgs e)
        {
            //MainScreenFinalResultsTxtBox
             
        }

        private void outputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }
}
