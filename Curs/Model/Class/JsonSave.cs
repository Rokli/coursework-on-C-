using Curs.View.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public class JsonSave
    {
        public List<Point> _buttLocation { get; set; } = new List<Point>();
        public List<Size> _buttSize { get; set; } = new List<Size>();
        public List<string> _buttImage { get; set; } = new List<string>();
        public void Save(List<AbstractPanelButton> butt, string filepath)
        {
            foreach(AbstractPanelButton b in butt)
            {
                _buttLocation.Add(b.Location);
                _buttSize.Add(b.Size);
                _buttImage.Add(b._FromFile);
            }
            StreamWriter writer = new StreamWriter(filepath, false);
            string json = JsonConvert.SerializeObject(this);
            writer.WriteAsync(json);
            writer.Dispose();
        }
    }
}
