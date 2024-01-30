using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public static class Distribution
    {
        public static string[] _name { get; } = ["circle.png", "text.png"];
        public static AbstractPanelButton DistributionButton(string fromFile)
        {
            string[] word = fromFile.Split("\\");
            if (word[word.Length-1] == _name[0] || word[word.Length-1] == _name[1]) 
                return new PanelButton(fromFile);
            else return new ArrowPanel(fromFile);
        }
        public static bool DistributionImage(string fromFile)
        {
            string[] word = fromFile.Split("\\");
            if (word[word.Length - 1] == _name[1])
                return true;
            else return false;
        }
    }
}
