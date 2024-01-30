using Curs.Model.Class;
using Curs.Presenter.Interface;
using Curs.View.Class;
using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Presenter.Class
{
    public class MainPesenter
    {
        public IMainView _mainView { get; set; }
        public MainModel _model { get; set; }
        public MainPesenter(IMainView mainView, MainModel model)
        {
            _mainView = mainView;
            _model = model;
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            EventHandler create = Create;
            LeftButton butt = new LeftButton(new Point(10, 0), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\circle.png", create);
            _mainView.InputControls = butt;
            //_mainView.InputControls = new LeftButton(new Point(10, 60));
            //_mainView.InputControls = new LeftButton(new Point(10, 120));
            //_mainView.InputControls = new LeftButton(new Point(10, 180));
            //_mainView.InputControls = new LeftButton(new Point(10, 240));
        }
        private void Create(object sender, EventArgs e)
        {
            LeftButton butt  = sender as LeftButton;
            _mainView.InputPanel = new PanelButton(butt._fromFile);
        }
    }
}
