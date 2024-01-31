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

        private TextBox? textBox1;
        private Button? button1;
        public string? TextBox { get; private set; }
        public ModuleText(string? text)
        {
            TextBox = text;
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
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(103, 160);
            button1.Name = "button1";
            button1.Size = new Size(147, 40);
            button1.TabIndex = 0;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(103, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = TextBox;
            // 
            // ModuleText
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(356, 282);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "ModuleText";
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox = textBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
