﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public class LeftButton : Button
    {
        public string _fromFile { get; init; }
        public LeftButton(Point location, string fromFile, EventHandler eventButt) 
        {
            Click += eventButt;
            _fromFile = fromFile;
            Size = new Size(50,50);
            Location = location;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(fromFile);
        }
    }
}
