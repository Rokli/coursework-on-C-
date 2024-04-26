namespace Curs.View.Class
{
    partial class FMSWindow
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
            inputForTabel = new TextBox();
            label1 = new Label();
            table = new DataGridView();
            CreateTable = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // inputForTabel
            // 
            inputForTabel.Location = new Point(253, 6);
            inputForTabel.Name = "inputForTabel";
            inputForTabel.Size = new Size(125, 27);
            inputForTabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 1;
            label1.Text = "Сколько значений в алфавите?";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(22, 39);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(521, 341);
            table.TabIndex = 2;
            table.Visible = false;
            // 
            // CreateTable
            // 
            CreateTable.Location = new Point(384, 6);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(159, 29);
            CreateTable.TabIndex = 3;
            CreateTable.Text = "Создать таблицу";
            CreateTable.UseVisualStyleBackColor = true;
            // 
            // FMSWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTable);
            Controls.Add(table);
            Controls.Add(label1);
            Controls.Add(inputForTabel);
            Name = "FMSWindow";
            Text = "FMS";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputForTabel;
        private Label label1;
        private DataGridView table;
        private Button CreateTable;
    }
}