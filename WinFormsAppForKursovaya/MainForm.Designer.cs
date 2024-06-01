namespace WinFormsAppForKursovaya
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPageFullNums = new TabPage();
            RightValues = new TextBox();
            OutputTheReverseCode = new TextBox();
            OutputDirecCode = new TextBox();
            OutputAdditionalCode = new TextBox();
            OutputUnsignedCode = new TextBox();
            InputNum = new TextBox();
            ComboBoxOfCell = new ComboBox();
            ResultButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageDoubleNums = new TabPage();
            MantiseOutput = new TextBox();
            DegreeOutput = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            resButton2 = new Button();
            SignOutput = new TextBox();
            inputForPhysicalNums = new TextBox();
            tabControl1.SuspendLayout();
            tabPageFullNums.SuspendLayout();
            tabPageDoubleNums.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFullNums);
            tabControl1.Controls.Add(tabPageDoubleNums);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabPageFullNums
            // 
            tabPageFullNums.Controls.Add(RightValues);
            tabPageFullNums.Controls.Add(OutputTheReverseCode);
            tabPageFullNums.Controls.Add(OutputDirecCode);
            tabPageFullNums.Controls.Add(OutputAdditionalCode);
            tabPageFullNums.Controls.Add(OutputUnsignedCode);
            tabPageFullNums.Controls.Add(InputNum);
            tabPageFullNums.Controls.Add(ComboBoxOfCell);
            tabPageFullNums.Controls.Add(ResultButton);
            tabPageFullNums.Controls.Add(label7);
            tabPageFullNums.Controls.Add(label6);
            tabPageFullNums.Controls.Add(label5);
            tabPageFullNums.Controls.Add(label4);
            tabPageFullNums.Controls.Add(label3);
            tabPageFullNums.Controls.Add(label2);
            tabPageFullNums.Controls.Add(label1);
            tabPageFullNums.Location = new Point(4, 29);
            tabPageFullNums.Margin = new Padding(3, 4, 3, 4);
            tabPageFullNums.Name = "tabPageFullNums";
            tabPageFullNums.Padding = new Padding(3, 4, 3, 4);
            tabPageFullNums.Size = new Size(789, 567);
            tabPageFullNums.TabIndex = 0;
            tabPageFullNums.Text = "целые числа";
            tabPageFullNums.UseVisualStyleBackColor = true;
            // 
            // RightValues
            // 
            RightValues.Font = new Font("Segoe UI", 16F);
            RightValues.Location = new Point(518, 41);
            RightValues.Margin = new Padding(3, 4, 3, 4);
            RightValues.Multiline = true;
            RightValues.Name = "RightValues";
            RightValues.ReadOnly = true;
            RightValues.Size = new Size(260, 437);
            RightValues.TabIndex = 0;
            RightValues.Text = "Для 8 бит:\r\nот 0 до -128\r\nот 1 до 255\r\nДля 16 бит:\r\nот 0 до -32,768\r\nот 1 до 32,767\r\nДля 32 бит:\r\nот 0 до -2,147,483,648\r\nот 1 до 2,147,483,647";
            // 
            // OutputTheReverseCode
            // 
            OutputTheReverseCode.Font = new Font("Segoe UI", 18F);
            OutputTheReverseCode.Location = new Point(7, 331);
            OutputTheReverseCode.Margin = new Padding(3, 4, 3, 4);
            OutputTheReverseCode.Multiline = true;
            OutputTheReverseCode.Name = "OutputTheReverseCode";
            OutputTheReverseCode.ReadOnly = true;
            OutputTheReverseCode.Size = new Size(500, 55);
            OutputTheReverseCode.TabIndex = 13;
            // 
            // OutputDirecCode
            // 
            OutputDirecCode.Font = new Font("Segoe UI", 18F);
            OutputDirecCode.Location = new Point(7, 233);
            OutputDirecCode.Margin = new Padding(3, 4, 3, 4);
            OutputDirecCode.Multiline = true;
            OutputDirecCode.Name = "OutputDirecCode";
            OutputDirecCode.ReadOnly = true;
            OutputDirecCode.Size = new Size(500, 55);
            OutputDirecCode.TabIndex = 12;
            // 
            // OutputAdditionalCode
            // 
            OutputAdditionalCode.Font = new Font("Segoe UI", 18F);
            OutputAdditionalCode.Location = new Point(7, 423);
            OutputAdditionalCode.Margin = new Padding(3, 4, 3, 4);
            OutputAdditionalCode.Multiline = true;
            OutputAdditionalCode.Name = "OutputAdditionalCode";
            OutputAdditionalCode.ReadOnly = true;
            OutputAdditionalCode.Size = new Size(500, 55);
            OutputAdditionalCode.TabIndex = 11;
            // 
            // OutputUnsignedCode
            // 
            OutputUnsignedCode.Font = new Font("Segoe UI", 18F);
            OutputUnsignedCode.Location = new Point(7, 140);
            OutputUnsignedCode.Margin = new Padding(3, 4, 3, 4);
            OutputUnsignedCode.Multiline = true;
            OutputUnsignedCode.Name = "OutputUnsignedCode";
            OutputUnsignedCode.ReadOnly = true;
            OutputUnsignedCode.Size = new Size(500, 55);
            OutputUnsignedCode.TabIndex = 10;
            // 
            // InputNum
            // 
            InputNum.BackColor = SystemColors.MenuBar;
            InputNum.Font = new Font("Segoe UI", 18F);
            InputNum.Location = new Point(7, 41);
            InputNum.Margin = new Padding(3, 4, 3, 4);
            InputNum.Multiline = true;
            InputNum.Name = "InputNum";
            InputNum.Size = new Size(287, 55);
            InputNum.TabIndex = 9;
            // 
            // ComboBoxOfCell
            // 
            ComboBoxOfCell.AutoCompleteCustomSource.AddRange(new string[] { "8 бит", "16 бит ", "32 бита" });
            ComboBoxOfCell.BackColor = SystemColors.MenuBar;
            ComboBoxOfCell.Font = new Font("Segoe UI", 12F);
            ComboBoxOfCell.FormattingEnabled = true;
            ComboBoxOfCell.Items.AddRange(new object[] { "8 бит", "16 бит", "32 бита" });
            ComboBoxOfCell.Location = new Point(313, 48);
            ComboBoxOfCell.Margin = new Padding(3, 4, 3, 4);
            ComboBoxOfCell.Name = "ComboBoxOfCell";
            ComboBoxOfCell.Size = new Size(163, 36);
            ComboBoxOfCell.TabIndex = 8;
            ComboBoxOfCell.Text = "8 бит";
            // 
            // ResultButton
            // 
            ResultButton.Dock = DockStyle.Bottom;
            ResultButton.Font = new Font("Segoe UI", 22F);
            ResultButton.ImageAlign = ContentAlignment.TopCenter;
            ResultButton.Location = new Point(3, 491);
            ResultButton.Margin = new Padding(3, 4, 3, 4);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(783, 72);
            ResultButton.TabIndex = 7;
            ResultButton.Text = "превести";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(313, 9);
            label7.Name = "label7";
            label7.Size = new Size(135, 32);
            label7.TabIndex = 6;
            label7.Text = "кол-во бит";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(518, 4);
            label6.Name = "label6";
            label6.Size = new Size(260, 32);
            label6.TabIndex = 5;
            label6.Text = "допустимые значения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(7, 391);
            label5.Name = "label5";
            label5.Size = new Size(209, 28);
            label5.TabIndex = 4;
            label5.Text = "дополнительный код";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(7, 293);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 3;
            label4.Text = "обратный код";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(7, 196);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 2;
            label3.Text = "прямой код";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(7, 101);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "двоичный код";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "десятичное число ";
            // 
            // tabPageDoubleNums
            // 
            tabPageDoubleNums.Controls.Add(MantiseOutput);
            tabPageDoubleNums.Controls.Add(DegreeOutput);
            tabPageDoubleNums.Controls.Add(label11);
            tabPageDoubleNums.Controls.Add(label10);
            tabPageDoubleNums.Controls.Add(label9);
            tabPageDoubleNums.Controls.Add(label8);
            tabPageDoubleNums.Controls.Add(resButton2);
            tabPageDoubleNums.Controls.Add(SignOutput);
            tabPageDoubleNums.Controls.Add(inputForPhysicalNums);
            tabPageDoubleNums.Location = new Point(4, 29);
            tabPageDoubleNums.Margin = new Padding(3, 4, 3, 4);
            tabPageDoubleNums.Name = "tabPageDoubleNums";
            tabPageDoubleNums.Padding = new Padding(3, 4, 3, 4);
            tabPageDoubleNums.Size = new Size(789, 567);
            tabPageDoubleNums.TabIndex = 1;
            tabPageDoubleNums.Text = "вещественные числа";
            tabPageDoubleNums.UseVisualStyleBackColor = true;
            // 
            // MantiseOutput
            // 
            MantiseOutput.Font = new Font("Microsoft Sans Serif", 20F);
            MantiseOutput.Location = new Point(8, 252);
            MantiseOutput.Name = "MantiseOutput";
            MantiseOutput.ReadOnly = true;
            MantiseOutput.Size = new Size(436, 45);
            MantiseOutput.TabIndex = 8;
            // 
            // DegreeOutput
            // 
            DegreeOutput.Font = new Font("Microsoft Sans Serif", 20F);
            DegreeOutput.Location = new Point(8, 172);
            DegreeOutput.Name = "DegreeOutput";
            DegreeOutput.ReadOnly = true;
            DegreeOutput.Size = new Size(160, 45);
            DegreeOutput.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 20F);
            label11.Location = new Point(450, 255);
            label11.Name = "label11";
            label11.Size = new Size(213, 39);
            label11.TabIndex = 6;
            label11.Text = "<--Мантисса";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 20F);
            label10.Location = new Point(206, 175);
            label10.Name = "label10";
            label10.Size = new Size(280, 39);
            label10.TabIndex = 5;
            label10.Text = "<--Биты порядка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20F);
            label9.Location = new Point(50, 100);
            label9.Name = "label9";
            label9.Size = new Size(279, 39);
            label9.TabIndex = 4;
            label9.Text = "<--Знаковый бит";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 22.2F);
            label8.Location = new Point(260, 25);
            label8.Name = "label8";
            label8.Size = new Size(222, 42);
            label8.TabIndex = 3;
            label8.Text = "Поле ввода";
            // 
            // resButton2
            // 
            resButton2.Font = new Font("Microsoft Sans Serif", 22.2F);
            resButton2.Location = new Point(8, 326);
            resButton2.Margin = new Padding(3, 4, 3, 4);
            resButton2.Name = "resButton2";
            resButton2.Size = new Size(344, 65);
            resButton2.TabIndex = 2;
            resButton2.Text = "Перевести";
            resButton2.UseVisualStyleBackColor = true;
            resButton2.Click += resButton2_Click;
            // 
            // SignOutput
            // 
            SignOutput.Font = new Font("Microsoft Sans Serif", 20F);
            SignOutput.Location = new Point(8, 94);
            SignOutput.Margin = new Padding(3, 4, 3, 4);
            SignOutput.Name = "SignOutput";
            SignOutput.ReadOnly = true;
            SignOutput.Size = new Size(36, 45);
            SignOutput.TabIndex = 1;
            // 
            // inputForPhysicalNums
            // 
            inputForPhysicalNums.Font = new Font("Microsoft Sans Serif", 22.2F);
            inputForPhysicalNums.Location = new Point(8, 22);
            inputForPhysicalNums.Margin = new Padding(3, 4, 3, 4);
            inputForPhysicalNums.Name = "inputForPhysicalNums";
            inputForPhysicalNums.Size = new Size(246, 49);
            inputForPhysicalNums.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(797, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPageFullNums.ResumeLayout(false);
            tabPageFullNums.PerformLayout();
            tabPageDoubleNums.ResumeLayout(false);
            tabPageDoubleNums.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageFullNums;
        private TabPage tabPageDoubleNums;
        private TextBox OutputTheReverseCode;
        private TextBox OutputDirecCode;
        private TextBox OutputAdditionalCode;
        private TextBox OutputUnsignedCode;
        private TextBox InputNum;
        private ComboBox ComboBoxOfCell;
        private Button ResultButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox RightValues;
        private TextBox SignOutput;
        private TextBox inputForPhysicalNums;
        private Button resButton2;
        private TextBox MantiseOutput;
        private TextBox DegreeOutput;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}