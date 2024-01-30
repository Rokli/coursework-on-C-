﻿using Curs.Model.Class;
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
        MainPanel panel { get; set; } = new MainPanel();

        public Button InputPanel { set => panel.Controls.Add(value); }
        public LeftButton InputControls { set => Controls.Add(value); }

        public MainView()
        {
            InitializeComponent();
            Controls.Add(panel);
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
    }
}