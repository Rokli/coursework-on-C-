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
        public void AddFuncForButton(EventHandler func);
        public int NumberInput();
        public bool CheckTextInput();
        public void SettingsTable(int number);
    }
}
