﻿using Curs.View.Class;
using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Presenter
{
    public class FSMPresenter
    {
        public IFMS _view { get; set; }
        public FSMPresenter(IFMS view)
        {
            _view = view;
        }
        public void ShowWindow()=>_view.ShowWindow();
        public void CreateTable(object sender, EventArgs e)
        {
            if(_view.TextInput == null)
            {
                Error error = new Error();
                error.Show();
            }
            else
            {

            }
        }
    }
}
