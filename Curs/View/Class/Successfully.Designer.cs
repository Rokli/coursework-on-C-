﻿namespace Curs.View.Class
{
    partial class Successfully
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 98);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 0;
            label1.Text = "Алгоритм прошёл успешно";
            // 
            // button1
            // 
            button1.Location = new Point(134, 134);
            button1.Name = "button1";
            button1.Size = new Size(157, 35);
            button1.TabIndex = 1;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Successfully
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 302);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Successfully";
            Text = "Successfully";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}