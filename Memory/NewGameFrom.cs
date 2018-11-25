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

namespace Memory
{
    public partial class NewGameFrom : Form
    {
        private Settings settings;
        public Settings Settings { get => settings; }

        public NewGameFrom()
        {
            InitializeComponent();
            this.settings = null;
        }


        #region methodes
        private Settings makeSettings()
        {
            if (validation())
            {
                int rows = Int32.Parse(rowTextBox.Text);
                int columns = Int32.Parse(columnTextBox.Text);
                int pears = Int32.Parse(pearTextBox.Text);
                int pictures = Int32.Parse(picturesTextBox.Text);
                return new Settings(rows, columns, pears, pictures);
            }
            return null;
        }
        private bool validation()
        {
            bool rowCheck = checkIfInt(rowTextBox);
            bool columnChek = checkIfInt(columnTextBox);
            bool pearChek = checkIfInt(pearTextBox);
            bool picturesCheck = checkIfInt(picturesTextBox);
            return rowCheck && columnChek && pearChek && picturesCheck;
        }
        private bool checkIfInt(TextBox textBox)
        {
            int temp;
            if( textBox.Text != "" && Int32.TryParse(textBox.Text,out temp))
            {
                textBox.BackColor = Color.White;
                return true;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
                return false;
            }
        }
        #endregion

        #region events
        private void okButton_Click(object sender, EventArgs e)
        {
            this.settings = makeSettings();
            if(settings != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.settings = Settings.loadFromFile(dialog.FileName);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nesto");
        }
    }
}
