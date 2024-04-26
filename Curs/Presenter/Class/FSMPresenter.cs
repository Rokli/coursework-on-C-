using Curs.Model.FMS.Class;
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
        public FSM fsm { get; set; } = new FSM();
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
                string[] array = new string[3];
                int i = 0;
                foreach(DataGridViewCell columm in row.Cells)
                {
                    array[i] = columm.Value.ToString();
                    i++;
                }
                i = 0;
                FillingOutFSM(array);
            }
        }
        public void FillingOutFSM(string[] array)
        {

            fsm.AddState(0, false);
            fsm.AddState(1, false);
            fsm.AddState(2, true);

            fsm.AddTransition(0, 'A', 1);
            fsm.AddTransition(1, 'B', 2);
            fsm.AddTransition(2, 'C', 1);
            _view.SelectionResult(fsm.Accepts(_view.GetInputCheck()));
        }

    }
}
