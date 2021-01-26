using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StateCap
{
    public partial class AddStateCapForm : Form
    {
        /// <summary>
        /// we use the file patch because it's not in the default bin. 
        /// </summary>
        string filename = @"C:\Users\dalli\source\repos\StateCap\statecap.txt";
        public AddStateCapForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// We load the file before the form loads. We add each line to a list and display them in the list box. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStateCapForm_Load(object sender, EventArgs e)
        {

            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText(filename);
                while (!inputFile.EndOfStream)
                {
                    LstBoxStateCaps.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
        }
        /// <summary>
        /// We take the user input and append it to the end of the text file. We first make sure there is valid input. We concatenate the two user inputs from the text boxes. We append the text and close the file. We also add the concatenated string to the list so it is displayed on the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string userState = TxtBoxState.Text;
            string userCapital = TxtBoxCapital.Text;
            if (userState != "" && userCapital != "")
            {
                string statecap = userState + "," + userCapital;
                try
                {
                StreamWriter outputFile = File.AppendText(filename);
                    outputFile.WriteLine(statecap);
                    outputFile.Close();

                    LstBoxStateCaps.Items.Add(statecap);
                    TxtBoxState.Clear();
                    TxtBoxCapital.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

     
                }
            }
        }
    }
}
