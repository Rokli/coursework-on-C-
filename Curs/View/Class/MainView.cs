using Curs.Model.Class;
using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.View.Class
{
    public class MainView : Form, IMainView
    {
        MainPanel _panel { get; set; } = new MainPanel();

        public Button InputPanel { set => _panel.Controls.Add(value); }
        public LeftButton InputControls { set => Controls.Add(value); }
        public Button RemovePanel { set => _panel.Controls.Remove(value); }

        public MainView()
        {
            InitializeComponent();
            Controls.Add(_panel);
        }


        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MainView
            // 
            ClientSize = new Size(600, 600);
            Name = "MainView";
            ResumeLayout(false);
        }

        public void ClearPanel()=>_panel.Controls.Clear();
    }
}
