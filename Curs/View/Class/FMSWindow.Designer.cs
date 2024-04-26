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
            inputForTabelRow = new TextBox();
            label1 = new Label();
            table = new DataGridView();
            CreateTable = new Button();
            label2 = new Label();
            inputForFSM = new TextBox();
            checkFSM = new Button();
            label3 = new Label();
            alphabetInput = new TextBox();
            alphabetEnter = new Button();
            label4 = new Label();
            inputForTabelColumn = new TextBox();
            label5 = new Label();
            firsStateInput = new TextBox();
            endState = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // inputForTabelRow
            // 
            inputForTabelRow.Location = new Point(170, 6);
            inputForTabelRow.Name = "inputForTabelRow";
            inputForTabelRow.Size = new Size(125, 27);
            inputForTabelRow.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Сколько строк?";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(20, 78);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(529, 312);
            table.TabIndex = 2;
            table.Visible = false;
            // 
            // CreateTable
            // 
            CreateTable.Location = new Point(301, 6);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(159, 68);
            CreateTable.TabIndex = 3;
            CreateTable.Text = "Создать таблицу";
            CreateTable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 515);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 4;
            label2.Text = "Ввод строки, для проверки:";
            // 
            // inputForFSM
            // 
            inputForFSM.Location = new Point(226, 512);
            inputForFSM.Name = "inputForFSM";
            inputForFSM.Size = new Size(142, 27);
            inputForFSM.TabIndex = 5;
            // 
            // checkFSM
            // 
            checkFSM.Location = new Point(382, 512);
            checkFSM.Name = "checkFSM";
            checkFSM.Size = new Size(159, 27);
            checkFSM.TabIndex = 6;
            checkFSM.Text = "Проверить алгоритм";
            checkFSM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 416);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 8;
            label3.Text = "Ввод алфавита:";
            // 
            // alphabetInput
            // 
            alphabetInput.Location = new Point(226, 413);
            alphabetInput.Name = "alphabetInput";
            alphabetInput.Size = new Size(142, 27);
            alphabetInput.TabIndex = 9;
            // 
            // alphabetEnter
            // 
            alphabetEnter.Location = new Point(382, 413);
            alphabetEnter.Name = "alphabetEnter";
            alphabetEnter.Size = new Size(159, 27);
            alphabetEnter.TabIndex = 10;
            alphabetEnter.Text = "Ввести";
            alphabetEnter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 45);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 12;
            label4.Text = "Сколько столбцов?";
            // 
            // inputForTabelColumn
            // 
            inputForTabelColumn.Location = new Point(170, 45);
            inputForTabelColumn.Name = "inputForTabelColumn";
            inputForTabelColumn.Size = new Size(125, 27);
            inputForTabelColumn.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 449);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 13;
            label5.Text = "Начальное состояние:";
            // 
            // firsStateInput
            // 
            firsStateInput.Location = new Point(226, 446);
            firsStateInput.Name = "firsStateInput";
            firsStateInput.Size = new Size(142, 27);
            firsStateInput.TabIndex = 14;
            // 
            // endState
            // 
            endState.Location = new Point(226, 479);
            endState.Name = "endState";
            endState.Size = new Size(142, 27);
            endState.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 482);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 15;
            label6.Text = "Конечное состояние:";
            // 
            // FMSWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 560);
            Controls.Add(endState);
            Controls.Add(label6);
            Controls.Add(firsStateInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputForTabelColumn);
            Controls.Add(alphabetEnter);
            Controls.Add(alphabetInput);
            Controls.Add(label3);
            Controls.Add(checkFSM);
            Controls.Add(inputForFSM);
            Controls.Add(label2);
            Controls.Add(CreateTable);
            Controls.Add(table);
            Controls.Add(label1);
            Controls.Add(inputForTabelRow);
            Name = "FMSWindow";
            Text = "FMS";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputForTabelRow;
        private Label label1;
        private DataGridView table;
        private Button CreateTable;
        private Label label2;
        private TextBox inputForFSM;
        private Button checkFSM;
        private Label label3;
        private TextBox alphabetInput;
        private Button alphabetEnter;
        private Label label4;
        private TextBox inputForTabelColumn;
        private Label label5;
        private TextBox firsStateInput;
        private TextBox endState;
        private Label label6;
    }
}