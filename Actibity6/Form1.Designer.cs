namespace Actibity6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            buttonZero = new Button();
            buttonDicimal = new Button();
            buttonPlus = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonOne = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonMinus = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonMultiply = new Button();
            buttonSqr = new Button();
            buttonPower = new Button();
            buttonLog = new Button();
            buttonDivide = new Button();
            buttonClear = new Button();
            buttonSin = new Button();
            buttonCos = new Button();
            buttonTan = new Button();
            buttonBackSpace = new Button();
            buttonEquals = new Button();
            labelHistory = new Label();
            buttonTanh = new Button();
            buttonSinh = new Button();
            buttonCosh = new Button();
            buttonFloor = new Button();
            buttonCeil = new Button();
            buttonTruncate = new Button();
            advance_basic = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(39, 49);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(377, 61);
            textBoxInput.TabIndex = 0;
            textBoxInput.Text = "0";
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = Color.DimGray;
            buttonZero.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonZero.ForeColor = Color.White;
            buttonZero.Location = new Point(114, 398);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(71, 50);
            buttonZero.TabIndex = 1;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += DigitBtn_Click;
            // 
            // buttonDicimal
            // 
            buttonDicimal.BackColor = Color.DimGray;
            buttonDicimal.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonDicimal.ForeColor = Color.White;
            buttonDicimal.Location = new Point(191, 398);
            buttonDicimal.Name = "buttonDicimal";
            buttonDicimal.Size = new Size(71, 50);
            buttonDicimal.TabIndex = 2;
            buttonDicimal.Text = ".";
            buttonDicimal.UseVisualStyleBackColor = false;
            buttonDicimal.Click += buttonDicimal_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.DarkOrange;
            buttonPlus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonPlus.ForeColor = Color.White;
            buttonPlus.Location = new Point(268, 398);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(71, 51);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = Color.DimGray;
            buttonTwo.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonTwo.ForeColor = Color.White;
            buttonTwo.Location = new Point(114, 342);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(71, 50);
            buttonTwo.TabIndex = 4;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += DigitBtn_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = Color.DimGray;
            buttonThree.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonThree.ForeColor = Color.White;
            buttonThree.Location = new Point(191, 342);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(71, 50);
            buttonThree.TabIndex = 5;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += DigitBtn_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = Color.DimGray;
            buttonOne.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonOne.ForeColor = Color.White;
            buttonOne.Location = new Point(38, 342);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(71, 50);
            buttonOne.TabIndex = 6;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += DigitBtn_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = Color.DimGray;
            buttonFour.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonFour.ForeColor = Color.White;
            buttonFour.Location = new Point(38, 286);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(71, 50);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += DigitBtn_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = Color.DimGray;
            buttonFive.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonFive.ForeColor = Color.White;
            buttonFive.Location = new Point(115, 286);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(71, 50);
            buttonFive.TabIndex = 8;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += DigitBtn_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = Color.DimGray;
            buttonSix.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonSix.ForeColor = Color.White;
            buttonSix.Location = new Point(191, 286);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(71, 50);
            buttonSix.TabIndex = 9;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += DigitBtn_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.DarkOrange;
            buttonMinus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(268, 342);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(71, 50);
            buttonMinus.TabIndex = 10;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = Color.DimGray;
            buttonSeven.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonSeven.ForeColor = Color.White;
            buttonSeven.Location = new Point(38, 230);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(71, 50);
            buttonSeven.TabIndex = 11;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += DigitBtn_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = Color.DimGray;
            buttonEight.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonEight.ForeColor = Color.White;
            buttonEight.Location = new Point(115, 230);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(71, 50);
            buttonEight.TabIndex = 12;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += DigitBtn_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = Color.DimGray;
            buttonNine.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            buttonNine.ForeColor = Color.White;
            buttonNine.Location = new Point(191, 230);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(71, 50);
            buttonNine.TabIndex = 13;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += DigitBtn_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.DarkOrange;
            buttonMultiply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonMultiply.ForeColor = Color.White;
            buttonMultiply.Location = new Point(268, 286);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(71, 50);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonSqr
            // 
            buttonSqr.BackColor = Color.DarkGray;
            buttonSqr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonSqr.ForeColor = Color.White;
            buttonSqr.Location = new Point(38, 174);
            buttonSqr.Name = "buttonSqr";
            buttonSqr.Size = new Size(71, 50);
            buttonSqr.TabIndex = 15;
            buttonSqr.Text = "sqr";
            buttonSqr.UseVisualStyleBackColor = false;
            buttonSqr.Click += buttonSqr_Click;
            // 
            // buttonPower
            // 
            buttonPower.BackColor = Color.DarkGray;
            buttonPower.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonPower.ForeColor = Color.White;
            buttonPower.Location = new Point(115, 174);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(71, 50);
            buttonPower.TabIndex = 16;
            buttonPower.Text = "pow";
            buttonPower.UseVisualStyleBackColor = false;
            buttonPower.Click += buttonPower_Click;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = Color.DarkGray;
            buttonLog.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonLog.ForeColor = Color.White;
            buttonLog.Location = new Point(192, 174);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(71, 50);
            buttonLog.TabIndex = 17;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += buttonLog_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.DarkOrange;
            buttonDivide.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonDivide.ForeColor = Color.White;
            buttonDivide.Location = new Point(268, 230);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(71, 50);
            buttonDivide.TabIndex = 18;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.DarkOrange;
            buttonClear.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(37, 399);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(71, 50);
            buttonClear.TabIndex = 19;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = Color.DarkGray;
            buttonSin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonSin.ForeColor = Color.White;
            buttonSin.Location = new Point(37, 116);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(71, 50);
            buttonSin.TabIndex = 20;
            buttonSin.Text = "sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += buttonSin_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = Color.DarkGray;
            buttonCos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonCos.ForeColor = Color.White;
            buttonCos.Location = new Point(115, 116);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(71, 50);
            buttonCos.TabIndex = 21;
            buttonCos.Text = "cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += buttonCos_Click;
            // 
            // buttonTan
            // 
            buttonTan.BackColor = Color.DarkGray;
            buttonTan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonTan.ForeColor = Color.White;
            buttonTan.Location = new Point(192, 116);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(71, 50);
            buttonTan.TabIndex = 22;
            buttonTan.Text = "tan";
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Click += buttonTan_Click_1;
            // 
            // buttonBackSpace
            // 
            buttonBackSpace.BackColor = Color.DarkOrange;
            buttonBackSpace.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonBackSpace.ForeColor = Color.White;
            buttonBackSpace.Location = new Point(268, 116);
            buttonBackSpace.Name = "buttonBackSpace";
            buttonBackSpace.Size = new Size(71, 50);
            buttonBackSpace.TabIndex = 23;
            buttonBackSpace.Text = "<---";
            buttonBackSpace.UseVisualStyleBackColor = false;
            buttonBackSpace.Click += buttonBackSpace_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.DarkOrange;
            buttonEquals.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonEquals.ForeColor = Color.White;
            buttonEquals.Location = new Point(269, 174);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(71, 50);
            buttonEquals.TabIndex = 24;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Location = new Point(39, 26);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(56, 20);
            labelHistory.TabIndex = 25;
            labelHistory.Text = "History";
            labelHistory.Click += labelHistory_Click;
            // 
            // buttonTanh
            // 
            buttonTanh.BackColor = Color.DarkOrange;
            buttonTanh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonTanh.ForeColor = Color.White;
            buttonTanh.Location = new Point(345, 116);
            buttonTanh.Name = "buttonTanh";
            buttonTanh.Size = new Size(71, 50);
            buttonTanh.TabIndex = 26;
            buttonTanh.Text = "tanh";
            buttonTanh.UseVisualStyleBackColor = false;
            buttonTanh.Click += buttonTanh_Click;
            // 
            // buttonSinh
            // 
            buttonSinh.BackColor = Color.DarkOrange;
            buttonSinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonSinh.ForeColor = Color.White;
            buttonSinh.Location = new Point(346, 174);
            buttonSinh.Name = "buttonSinh";
            buttonSinh.Size = new Size(71, 50);
            buttonSinh.TabIndex = 27;
            buttonSinh.Text = "sinh";
            buttonSinh.UseVisualStyleBackColor = false;
            buttonSinh.Click += buttonSinh_Click;
            // 
            // buttonCosh
            // 
            buttonCosh.BackColor = Color.DarkOrange;
            buttonCosh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonCosh.ForeColor = Color.White;
            buttonCosh.Location = new Point(346, 230);
            buttonCosh.Name = "buttonCosh";
            buttonCosh.Size = new Size(71, 50);
            buttonCosh.TabIndex = 28;
            buttonCosh.Text = "cosh";
            buttonCosh.UseVisualStyleBackColor = false;
            buttonCosh.Click += buttonCosh_Click;
            // 
            // buttonFloor
            // 
            buttonFloor.BackColor = Color.DarkOrange;
            buttonFloor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonFloor.ForeColor = Color.White;
            buttonFloor.Location = new Point(346, 286);
            buttonFloor.Name = "buttonFloor";
            buttonFloor.Size = new Size(71, 50);
            buttonFloor.TabIndex = 29;
            buttonFloor.Text = "floor";
            buttonFloor.UseVisualStyleBackColor = false;
            buttonFloor.Click += buttonFloor_Click;
            // 
            // buttonCeil
            // 
            buttonCeil.BackColor = Color.DarkOrange;
            buttonCeil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonCeil.ForeColor = Color.White;
            buttonCeil.Location = new Point(346, 343);
            buttonCeil.Name = "buttonCeil";
            buttonCeil.Size = new Size(71, 50);
            buttonCeil.TabIndex = 30;
            buttonCeil.Text = "ceil";
            buttonCeil.UseVisualStyleBackColor = false;
            buttonCeil.Click += buttonCeil_Click;
            // 
            // buttonTruncate
            // 
            buttonTruncate.BackColor = Color.DarkOrange;
            buttonTruncate.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTruncate.ForeColor = Color.White;
            buttonTruncate.Location = new Point(346, 398);
            buttonTruncate.Name = "buttonTruncate";
            buttonTruncate.Size = new Size(71, 50);
            buttonTruncate.TabIndex = 31;
            buttonTruncate.Text = "trunc";
            buttonTruncate.UseVisualStyleBackColor = false;
            buttonTruncate.Click += buttonTruncate_Click;
            // 
            // advance_basic
            // 
            advance_basic.AutoSize = true;
            advance_basic.Location = new Point(350, 26);
            advance_basic.Name = "advance_basic";
            advance_basic.Size = new Size(43, 20);
            advance_basic.TabIndex = 32;
            advance_basic.Text = "Basic";
            advance_basic.Click += advance_basic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(464, 481);
            Controls.Add(advance_basic);
            Controls.Add(buttonTruncate);
            Controls.Add(buttonCeil);
            Controls.Add(buttonFloor);
            Controls.Add(buttonCosh);
            Controls.Add(buttonSinh);
            Controls.Add(buttonTanh);
            Controls.Add(labelHistory);
            Controls.Add(buttonEquals);
            Controls.Add(buttonBackSpace);
            Controls.Add(buttonTan);
            Controls.Add(buttonCos);
            Controls.Add(buttonSin);
            Controls.Add(buttonClear);
            Controls.Add(buttonDivide);
            Controls.Add(buttonLog);
            Controls.Add(buttonPower);
            Controls.Add(buttonSqr);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonOne);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDicimal);
            Controls.Add(buttonZero);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonZero;
        private Button buttonDicimal;
        private Button buttonPlus;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonOne;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonMinus;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonMultiply;
        private Button buttonSqr;
        private Button buttonPower;
        private Button buttonLog;
        private Button buttonDivide;
        private Button buttonClear;
        private Button buttonSin;
        private Button buttonCos;
        private Button buttonTan;
        private Button buttonBackSpace;
        private Button buttonEquals;
        private Label labelHistory;
        private Button buttonTanh;
        private Button buttonSinh;
        private Button buttonCosh;
        private Button buttonFloor;
        private Button buttonCeil;
        private Button buttonTruncate;
        private Label advance_basic;
    }
}
