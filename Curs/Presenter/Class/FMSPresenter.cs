using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Presenter.Class
{
    public class FMSPresenter
    {
        public IFMS _view { get; set; }

        public FMSPresenter(IFMS view)
        {
            _view = view;
        }
        public void ShowWindow()=> _view.ShowWindow();
        public void CreateTable(object sender, EventArgs e)
        {
            if(_view.TextInput == null)
        }
    }
}
