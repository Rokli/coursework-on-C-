using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.View.Interface
{
    public interface IFMS
    {
        public void ShowWindow();
        public string GetFisrtState();
        public void AddFuncForInputButton(EventHandler func);
        public void AddFuncForCheckButton(EventHandler func);
        public DataGridViewRowCollection GetArrayRowColummTable();
        public string GetInputCheck();
        public void SelectionResult(bool selection);
        public int NumberInputRow();

        public string AlphabetInput();
        public bool CheckTextInput();
        public void SettingsTable(int row, int column);
        public int NumberInputColumn();
    }
}
