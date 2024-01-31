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
        public IMainView mainView { get; set; }
        public MainPesenter(IMainView mainView)
        {
            this.mainView = mainView;
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            EventHandler create = Create;
            EventHandler clear = ClearPanel;
            mainView.InputControls = new LeftButton(new Point(10, 10), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\circle.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 70), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-left.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 130), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-rigth.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 190), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-up.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 250), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-down.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 310), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-circle-rigth.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 370), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-circle-up.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 430), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-circle-left.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 490), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\arrow-circle-down.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 550), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\text.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 550), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\save.png", create);
            mainView.InputControls = new LeftButton(new Point(10, 610), "C:\\Users\\satal\\source\\repos\\Curs\\Curs\\Assets\\trash.png", clear);
        }
        private void Create(object sender, EventArgs e)
        {
            MouseEventHandler delete = DeleteButton;
            LeftButton butt = sender as LeftButton;
            AbstractPanelButton button = Distribution.DistributionButton(butt._fromFile);
            button.delete = delete;
            mainView.InputPanel = button;
        }
        private void ClearPanel(object sender, EventArgs e)=>mainView.ClearPanel();
        private void SavePanel(object sender, EventArgs e)=>

        private void DeleteButton(object sender, MouseEventArgs e)
        {
            AbstractPanelButton butt = sender as AbstractPanelButton;
            if (e.Button == MouseButtons.Right)
                mainView.RemovePanel = butt;
            
        }
    }
}
