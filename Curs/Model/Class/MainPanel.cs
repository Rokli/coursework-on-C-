using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public class MainPanel: Panel
    {
        public MainPanel()
        {
            Text = null;
            AutoSize = true;
            Size = new System.Drawing.Size(520,590);
            Location = new Point(70,0);
            BackColor = Color.Gray;
            Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        }
    }
}
