using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curs.View.Class
{
    public class ModuleText : Form
    {
        public string _textBox { get; private set; }
        public ModuleText(string text)
        {
            _textBox = text;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(91, 159);
            button1.Name = "button1";
            button1.Size = new Size(147, 40);
            button1.TabIndex = 0;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = _textBox;
            // 
            // ModuleText
            // 
            ClientSize = new Size(356, 282);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "ModuleText";
            ResumeLayout(false);
            PerformLayout();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private TextBox textBox1;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            _textBox = textBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
