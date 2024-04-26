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
        public string alphabet { get; set; }
        public Dictionary<string, Dictionary<string, string>> keyValuePairs { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        public string firstState {  get; set; }
        public string[] states { get; set; }
        public FSMPresenter(IFMS view)
        {
            _view = view;
            _view.AddFuncForInputButton(CreateTable);
            _view.AddFuncForCheckButton(FSMStart);
        }
        public void ShowWindow()=>_view.ShowWindow();
        public void CreateAlphabet() => alphabet = _view.AlphabetInput();
        public void CreateTable(object sender, EventArgs e)
        {
            if(!_view.CheckTextInput())
            {
                Error error = new Error();
                error.Show();
            }
            else
            {
                _view.SettingsTable(_view.NumberInputRow(),_view.NumberInputColumn());
            }
            states = new string[_view.NumberInputRow()];
        }
        public void FSMStart(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _view.GetArrayRowColummTable())
            {
                string[] array = new string[_view.NumberInputColumn()];
                int i = 0;
                foreach(DataGridViewCell columm in row.Cells)
                {
                    array[i] = columm.Value.ToString();
                    i++;
                }
                FillingOutFSM(array);
            }
        }
        public void CreateAlhabet()
        {
            int i = 0;
            foreach (DataGridViewRow row in _view.GetArrayRowColummTable())
            {
                states[i] = row.Cells[0].ToString();
                i++;
            }
        }
        public void FillingOutFSM(string[] array)
        {
            Dictionary<string,string> tmp = new Dictionary<string,string>();
            for(int i = 1; i <= array.Length-2; i += 2)
            {
                tmp.Add(array[i], array[i+1]);
            }
            keyValuePairs.Add(array[0],tmp);
            
            //FSM fsm = new FSM("ABC", ["A", "B","C"], "q1", ["q3"], new Dictionary<string, Dictionary<string, string>>
            //{
            //    ["q1"] = new Dictionary<string, string>
            //    {
            //        ["A"] = "q1",
            //        ["B"] = "q2",
            //    },
            //    ["q2"] = new Dictionary<string, string>
            //    {
            //        ["B"] = "q2",
            //        ["C"] = "q3"
            //    },
            //    ["q3"] = new Dictionary<string, string>
            //    {
            //        ["C"] = "q3"
            //    },
            //});
            //_view.SelectionResult(fsm.Start(_view.GetInputCheck()));
        }
        public void FSMTest()
        {
            FSM fsm = new FSM("01", ["q0", "q1"], "q0", ["q0"], new Dictionary<string, Dictionary<string, string>>
            {
                ["q0"] = new Dictionary<string, string>
                {
                    ["0"] = "q0",
                    ["1"] = "q0"
                },
                ["q1"] = new Dictionary<string, string>
                {
                    ["0"] = "q1",
                    ["1"] = "q1"
                },
            });
        }

    }
}
