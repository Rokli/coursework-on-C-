using Curs.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs.View.Class
{
    public partial class FMSWindow : Form, IFMS
    {

        public FMSWindow()
        {
            InitializeComponent();
        }
        public void ShowWindow()=>Show();
        public void AddFuncForButton(EventHandler func) => CreateTable.Click += func;
        public string TextInput()=> inputForTabel.Text;
    }
}
