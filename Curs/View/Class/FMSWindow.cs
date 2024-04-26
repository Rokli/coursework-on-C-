using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curs.View.Class
{
    public partial class FMSWindow : Form, IFMS
    {

        public FMSWindow()
        {
            InitializeComponent();
        }
        public void ShowWindow()=>Show();
        public void AddFuncForInputButton(EventHandler func) => CreateTable.Click += func;
        public void AddFuncForCheckButton(EventHandler func) => checkFSM.Click += func;
        public string GetInputCheck() => inputForFSM.Text;
        public DataGridViewRowCollection GetArrayRowColummTable() => table.Rows;
        public void AddRichTextBox(string text) => richTextBox.Text += text + "\n";
        public int NumberInput()=> Convert.ToInt32(inputForTabel.Text);
        public void SelectionResult(bool selection)
        {
            richTextBox.Text += "1";
            if (selection)
            {
                Successfully successfully = new Successfully();
                successfully.Show();
            }
            else
            {
                ErrorFSM errorFSM = new ErrorFSM();
                errorFSM.Show();
            }
        }
        public bool CheckTextInput()
        {
            if (string.IsNullOrEmpty(inputForTabel.Text))
                return false;
            if (Convert.ToInt32(inputForTabel.Text) < 0)
                return false;
            return true;
        }

        public void SettingsTable(int number)
        {
            table.AllowUserToAddRows = false;
            table.Visible = true;
            table.ColumnCount = 3;
            table.RowCount = number;
        }
        
    }
}
