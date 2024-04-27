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
    public partial class FSMWindow : Form, IFMS
    {

        public FSMWindow()
        {
            InitializeComponent();
        }
        public void ShowWindow()=>Show();
        public void AddFuncForInputButton(EventHandler func) => CreateTable.Click += func;
        public void AddFuncForCheckButton(EventHandler func) => checkFSM.Click += func;
        public string GetInputCheck() => inputForFSM.Text;
        public DataGridViewRowCollection GetArrayRowColummTable() => table.Rows;
        public int NumberInputRow()=> Convert.ToInt32(inputForTabelRow.Text);
        public int NumberInputColumn() => Convert.ToInt32(inputForTabelColumn.Text);
        public string AlphabetInput() => alphabetInput.Text;
        public string GetFisrtState()=>firsStateInput.Text;
        public string GetEndState() => endStateInput.Text;
        public void SelectionResult(bool selection)
        {
            if (selection)
                MessageBox.Show("Алгоритм прошёл успешно");
            else
                MessageBox.Show("Неправильно введены данные");
        }
        public bool CheckTextInput()
        {
            if (string.IsNullOrEmpty(inputForTabelRow.Text))
                return false;
            if (string.IsNullOrEmpty(inputForTabelColumn.Text))
                return false;
            if (Convert.ToInt32(inputForTabelRow.Text) < 0)
                return false;
            if (Convert.ToInt32(inputForTabelColumn.Text) < 0)
                return false;
            if (Convert.ToInt32(inputForTabelColumn.Text) % 2 == 0)
                return false;
            return true;
        }

        public void SettingsTable(int row, int column)
        {
            table.AllowUserToAddRows = false;
            table.Visible = true;
            table.ColumnCount = column;
            table.RowCount = row;
        }
        
    }
}
