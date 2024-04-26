﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.View.Interface
{
    public interface IFMS
    {
        public void ShowWindow();
        public void AddFuncForInputButton(EventHandler func);
        public void AddFuncForCheckButton(EventHandler func);
        public void AddRichTextBox(string text);
        public int NumberInput();
        public bool CheckTextInput();
        public void SettingsTable(int number);
    }
}
