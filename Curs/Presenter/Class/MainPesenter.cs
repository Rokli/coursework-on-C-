using Curs.Model.Class;
using Curs.Presenter.Interface;
using Curs.View.Class;
using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            EventHandler clear = ClearPanel;
            _mainView.InputControls = new LeftButton(new Point(10, 0), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\circle.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 60), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-left.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 120), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-rigth.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 180), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-up.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 240), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-down.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 300), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-circle.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 360), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\text.png", create);
            _mainView.InputControls = new LeftButton(new Point(10, 420), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\trash.png", clear);
        }
        private void Create(object sender, EventArgs e)
        {
            MouseEventHandler delete = DeleteButton;
            LeftButton butt = sender as LeftButton;
            AbstractPanelButton button = Distribution.DistributionButton(butt._fromFile);
            button.delete = delete;
            _mainView.InputPanel = button;
        }
        private void ClearPanel(object sender, EventArgs e)=>_mainView.ClearPanel();

        private void DeleteButton(object sender, MouseEventArgs e)
        {
            AbstractPanelButton butt = sender as AbstractPanelButton;
            if (e.Button == MouseButtons.Right)
                _mainView.RemovePanel = butt;
            
        }
    }
}
