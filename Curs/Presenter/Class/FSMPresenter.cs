using Curs.View.Class;
using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs.Presenter
{
    public class FSMPresenter
    {
        public IFMS _view { get; set; }
        public FSMPresenter(IFMS view)
        {
            _view = view;
            _view.AddFuncForInputButton(CreateTable);
            _view.AddFuncForCheckButton(FSMStart);
        }
        public void ShowWindow()=>_view.ShowWindow();
        public void CreateTable(object sender, EventArgs e)
        {
            if(!_view.CheckTextInput())
            {
                Error error = new Error();
                error.Show();
            }
            else
            {
                _view.SettingsTable(_view.NumberInput());
            }
        }
        public void FSMStart(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _view.GetArrayRowColummTable())
            {
                foreach(DataGridViewCell columm in row.Cells)
                {
                    _view.AddRichTextBox(columm.Value.ToString());
                }
            }
        }
    }
}
