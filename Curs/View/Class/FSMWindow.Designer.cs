namespace Curs.View.Class
{
    partial class FSMWindow
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
            CreateTableButton = new Button();
            label2 = new Label();
            inputForFSM = new TextBox();
            checkFSMButton = new Button();
            label3 = new Label();
            alphabetInput = new TextBox();
            label4 = new Label();
            inputForTabelColumn = new TextBox();
            label5 = new Label();
            firsStateInput = new TextBox();
            endStateInput = new TextBox();
            label6 = new Label();
            exitButton = new Button();
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
            table.Size = new Size(783, 312);
            table.TabIndex = 2;
            table.Visible = false;
            // 
            // CreateTableButton
            // 
            CreateTableButton.Location = new Point(301, 6);
            CreateTableButton.Name = "CreateTableButton";
            CreateTableButton.Size = new Size(159, 68);
            CreateTableButton.TabIndex = 3;
            CreateTableButton.Text = "Создать таблицу";
            CreateTableButton.UseVisualStyleBackColor = true;
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
            // checkFSMButton
            // 
            checkFSMButton.Location = new Point(382, 512);
            checkFSMButton.Name = "checkFSMButton";
            checkFSMButton.Size = new Size(159, 27);
            checkFSMButton.TabIndex = 6;
            checkFSMButton.Text = "Проверить алгоритм";
            checkFSMButton.UseVisualStyleBackColor = true;
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
            // endStateInput
            // 
            endStateInput.Location = new Point(226, 479);
            endStateInput.Name = "endStateInput";
            endStateInput.Size = new Size(142, 27);
            endStateInput.TabIndex = 16;
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
            // exitButton
            // 
            exitButton.Location = new Point(676, 512);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(127, 27);
            exitButton.TabIndex = 17;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // FSMWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 560);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(endStateInput);
            Controls.Add(label6);
            Controls.Add(firsStateInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputForTabelColumn);
            Controls.Add(alphabetInput);
            Controls.Add(label3);
            Controls.Add(checkFSMButton);
            Controls.Add(inputForFSM);
            Controls.Add(label2);
            Controls.Add(CreateTableButton);
            Controls.Add(table);
            Controls.Add(label1);
            Controls.Add(inputForTabelRow);
            Name = "FSMWindow";
            Text = "FMS";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputForTabelRow;
        private Label label1;
        private DataGridView table;
        private Button CreateTableButton;
        private Label label2;
        private TextBox inputForFSM;
        private Button checkFSMButton;
        private Label label3;
        private TextBox alphabetInput;
        private Label label4;
        private TextBox inputForTabelColumn;
        private Label label5;
        private TextBox firsStateInput;
        private TextBox endStateInput;
        private Label label6;
        private Button exitButton;
    }
}