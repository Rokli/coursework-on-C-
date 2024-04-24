using Curs.View.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public class PanelButton : AbstractPanelButton
    {
        public PanelButton(string FromFile) : base(FromFile)
        {
        }

        protected override void OnClick(EventArgs e)
        {
            TimeSpan time = DateTime.Now - lastClickTime;
            if (time.TotalMilliseconds < SystemInformation.DoubleClickTime)
            {
                OnDoubleClick(EventArgs.Empty);
            }
            else
            {
                base.OnClick(e);
            }
            lastClickTime = DateTime.Now;
        }
        protected override void OnDoubleClick(EventArgs e)
        { 
            ModuleText moduleText = new ModuleText(Text, Location);
            moduleText.Location = Location;
            moduleText.ShowDialog();
            Text = moduleText.TextBox;
            base.OnDoubleClick(e);
        }
    }
}
