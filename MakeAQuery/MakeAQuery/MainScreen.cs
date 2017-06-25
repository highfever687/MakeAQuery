using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MakeAQuery
{
    public partial class MainScreen : Form
    {
        public string finOutputText;
        public List<string> mainInputItems = new List<string>();
        public List<string> mainOutItems = new List<string>();
        public MainScreen()
        {
            InitializeComponent();

        }
        public MainScreen(string dataForm)
        {
            InitializeComponent();
            MainScreenFinalResultsTxtBox.Text = dataForm;

        }


        private void whereClauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void whereClauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void TypeOfQButtonMainScreen_Click(object sender, EventArgs e)
        {
         
            MainScreenFinalResultsTxtBox.Text += "UPDATE table_name SET column1 = value1, column2 = value2,... WHERE";
            string item = "";
            foreach (var i in TypeOfQueryListBox.SelectedIndices)
            {
                item += TypeOfQueryListBox.Items[(int)i] + Environment.NewLine;
            }
            
        }

        private void MainScreenFinalResultsTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreenFinalResultsTxtBox.Text += "Create table_name SET column1 = value1, column2 = value2,... WHERE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string getMainScreenText = MainScreenFinalResultsTxtBox.Text;
            string getDbName = dbNameTextBox.Text;
            //Add a try catch block here.. 6/25/2017
            if(getDbName == "")
            {
                MainScreenFinalResultsTxtBox.Text += "USE master;\r\n" +
                                                     "GO\r\n" +
                                                     "--Delete the TestDataBaseName database if it exists.\r\n" +
                                                     "IF EXISTS(SELECT * from sys.databases WHERE name='TestDataBaseName')\r\n" +
                                                     "BEGIN\r\n" +
                                                        "DROP DATABASE TestDataBaseName;\r\n" +
                                                     "END\r\n" +

                                                      "--Create a new database called TestDataBaseName.\r\n" +
                                                      "CREATE DATABASE TestDataBaseName;\r\n" +
                                                      "Press the F5 key to execute the code and create the database.\r\n";
            }
            else if (getDbName != null)
            {
                MainScreenFinalResultsTxtBox.Text += "USE master;\r\n" +
                                                         "GO\r\n" +
                                                         "--Delete the " + getDbName + " database if it exists.\r\n" +
                                                         "IF EXISTS(SELECT * from sys.databases WHERE name= '" + getDbName + "')\r\n" +
                                                         "BEGIN\r\n" +
                                                            "DROP DATABASE " + getDbName + ";\r\n" +
                                                         "END\r\n" +

                                                          "--Create a new database called " + getDbName + ".\r\n" +
                                                          "CREATE DATABASE " + getDbName + ";\r\n" +
                                                          "Press the F5 key to execute the code and create the database.\r\n";
            }
            else
            {
                Regex dbNameCreateMatch = new Regex("TestDataBaseName");
                string dbNewNameReplaceMatch = dbNameCreateMatch.Replace(MainScreenFinalResultsTxtBox.Text, dbNameTextBox.Text);
                MainScreenFinalResultsTxtBox.Text = "";
                MainScreenFinalResultsTxtBox.Text = dbNewNameReplaceMatch;
            }
            //MainScreenFinalResultsTxtBox.Text += "USE master;\r\n" +
            //                                         "GO\r\n" +
            //                                         "--Delete the TestDataBaseName database if it exists.\r\n" +
            //                                         "IF EXISTS(SELECT * from sys.databases WHERE name='TestDataBaseName')\r\n" +
            //                                         "BEGIN\r\n" +
            //                                            "DROP DATABASE TestDataBaseName;\r\n" +
            //                                         "END\r\n" +

            //                                          "--Create a new database called TestDataBaseName.\r\n" +
            //                                          "CREATE DATABASE TestDataBaseName;\r\n" +
            //                                          "Press the F5 key to execute the code and create the database.\r\n";
        }

        private void exampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //ClauseBuild storedProcedureGenericTemplate = new ClauseBuild();
                //storedProcedureGenericTemplate.WhereClause();
                StoreProcedure();
            }
            catch
            {
                MessageBox.Show("An Error Occured When Openning Your Input Folder For Where Clause Additons! Please Check The File And Try Again \r\b" + "OR You Closed The Last Window");
            }

        }

        public void StoreProcedure()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
            //new System.IO.StreamReader("c:\\Users\\highfever666\\Documents\\storedProcedureBasicTemplate.txt");
           new System.IO.StreamReader("c:\\Users\\highfever666\\Documents\\inputData.txt");
            while ((line = file.ReadLine()) != null)
            {
                mainInputItems.Add(line);
                mainOutItems.Add("'" + line + "'" + ",");
                counter++;

                file.Close();
            this.MainScreenFinalResultsTxtBox.Text += mainOutItems;
            }
           
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    button2_Click
        //}

        private void addAndReplaceDBName_Click(object sender, EventArgs e)
        {
            Regex dbNameCreateMatch2 = new Regex(dbNameTextBox.Text);
            string dbNewNameReplaceMatch2 = dbNameCreateMatch2.Replace(MainScreenFinalResultsTxtBox.Text, dbNameTextBox.Text);
            MainScreenFinalResultsTxtBox.Text = "";
            MainScreenFinalResultsTxtBox.Text = dbNewNameReplaceMatch2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string setTextFromDBNameTextBox = dbNameTextBox.Text;
            MainScreenFinalResultsTxtBox.Text += (setTextFromDBNameTextBox);
        }

        private void sendFromClipToWhereCbtn_Click(object sender, EventArgs e)
        {
            string setWhereTextFromClip = clipBoardTextBox.Text;
            MainScreenFinalResultsTxtBox.Text += (setWhereTextFromClip);
        }

        private void clearMainScreenBtn_Click(object sender, EventArgs e)
        {
            MainScreenFinalResultsTxtBox.Text = "";
        }

        private void moveToClipBoardBtn_Click(object sender, EventArgs e)
        {
            clipBoardTextBox.Text = MainScreenFinalResultsTxtBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clipBoardTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bringToMainScreenFinResultsBtn_Click(object sender, EventArgs e)
        {
           MainScreenFinalResultsTxtBox.Text += clipBoardTextBox.Text;
        }

        private void changeFontColorBtn_Click(object sender, EventArgs e)
        {
            MainScreenFinalResultsTxtBox.Text += "Red";
            string item = "";
            foreach (var i in selectFontColorListBox.SelectedIndices)
            {
                item += selectFontColorListBox.Items[(int)i] + Environment.NewLine;
            }
            
        }
    }
}
