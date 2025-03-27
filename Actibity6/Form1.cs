

using System;
using System.Net.NetworkInformation;

namespace Actibity6
{
    public partial class Form1 : Form
    {
        private List<string> history = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private double firstNum = 0.0;
        private double secondNum = 0.0;
        private double result = 0.0;
        private int operatorType = (int)MathOperations.NoOperator;


        public enum MathOperations
        {
            NoOperator = 0,
            Add = 1,
            Minus = 2,
            Multiply = 3,
            Divide = 4,
            Pow = 5

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "0";
        }




        private void DigitBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBoxInput.Text == "0")
            {
                textBoxInput.Clear();
            }
            textBoxInput.Text += btn.Text; //Appends the clicked button's text to the TextBox, allowing numeric input to be built up.
        }



        private void buttonDicimal_Click(object sender, EventArgs e)
        {
            if (!textBoxInput.Text.Contains('.'))
            {
                textBoxInput.Text += ".";
            }
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Add);
            //textBoxInput.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Minus);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Divide);
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Pow);

        }


        private void SaveValueAndOperatorType(int operation)
        {

            operatorType = operation;
            firstNum = Convert.ToDouble(textBoxInput.Text);
            textBoxInput.Text = "0";

        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {

            //string[] parts = textBoxInput.Text.Split(' ');
            secondNum = Convert.ToDouble(textBoxInput.Text);


            switch (operatorType)
            {
                case (int)MathOperations.Add:
                    result = firstNum + secondNum;
                    break;
                case (int)MathOperations.Minus:
                    result = firstNum - secondNum;
                    break;
                case (int)MathOperations.Multiply:
                    result = firstNum * secondNum;
                    break;
                case (int)MathOperations.Divide:
                    result = firstNum / secondNum;
                    break;
                case (int)MathOperations.Pow:
                    double poww = Convert.ToDouble(textBoxInput.Text);

                    result = result = Math.Pow(firstNum, secondNum);

                    break;



            }

            string operation = $"{firstNum} {GetOperatorSymbol()} {secondNum} = {result}";
            history.Add(operation);

            textBoxInput.Text = result.ToString();


        }
        private string GetOperatorSymbol()
        {
            return operatorType switch
            {
                (int)MathOperations.Add => "+",
                (int)MathOperations.Minus => "-",
                (int)MathOperations.Multiply => "*",
                (int)MathOperations.Divide => "/",
                (int)MathOperations.Pow => "^",
                _ => ""
            };
        }


        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            // Ensure there's something to delete
            if (textBoxInput.Text.Length > 0)
            {
                // Remove the last character
                textBoxInput.Text = textBoxInput.Text.Substring(0, textBoxInput.Text.Length - 1);
            }

            // Prevent empty text box
            if (textBoxInput.Text.Length == 0 || textBoxInput.Text == "-")
            {
                textBoxInput.Text = "0";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double sinn = Convert.ToDouble(textBoxInput.Text);
            sinn = Math.Sin(sinn);
            textBoxInput.Text = Convert.ToString(sinn);

            history.Add($"sin({lastInput}) = {sinn}");
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double coss = Convert.ToDouble(textBoxInput.Text);
            coss = Math.Cos(coss);
            textBoxInput.Text = Convert.ToString(coss);

            history.Add($"cos({lastInput}) = {coss}");
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double tann = Convert.ToDouble(textBoxInput.Text);
            tann = Math.Cos(tann);
            textBoxInput.Text = Convert.ToString(tann);

            history.Add($"tan({lastInput}) = {tann}");
        }



        private void buttonSqr_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double sq = Convert.ToDouble(textBoxInput.Text);
            sq = Math.Sqrt(sq);
            textBoxInput.Text = Convert.ToString(sq);

            history.Add($"sqr({lastInput}) = {sq}");
        }



        private void buttonLog_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double logg = Convert.ToDouble(textBoxInput.Text);
            logg = Math.Log10(logg);
            textBoxInput.Text = Convert.ToString(logg);

            history.Add($"log({lastInput}) = {logg}");
        }

        private void buttonTan_Click_1(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;
            double tann = Convert.ToDouble(textBoxInput.Text);
            tann = Math.Tan(tann);
            textBoxInput.Text = Convert.ToString(tann);

            history.Add($"tan({lastInput}) = {tann}");
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double tannh = Convert.ToDouble(textBoxInput.Text);
            tannh = Math.Tanh(tannh);
            textBoxInput.Text = Convert.ToString(tannh);

            history.Add($"tanh({lastInput}) = {tannh}");
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double sinnh = Convert.ToDouble(textBoxInput.Text);
            sinnh = Math.Sinh(sinnh);
            textBoxInput.Text = Convert.ToString(sinnh);

            history.Add($"sqr({lastInput}) = {sinnh}");
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double cossh = Convert.ToDouble(textBoxInput.Text);
            cossh = Math.Cosh(cossh);
            textBoxInput.Text = Convert.ToString(cossh);

            history.Add($"sqr({lastInput}) = {cossh}");
        }

        private void buttonFloor_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double floorr = Convert.ToDouble(textBoxInput.Text);
            floorr = Math.Floor(floorr);
            textBoxInput.Text = Convert.ToString(floorr);
                
            history.Add($"floor({lastInput}) = {floorr}");
        }

        private void buttonCeil_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double Ceill = Convert.ToDouble(textBoxInput.Text);
            Ceill = Math.Ceiling(Ceill);
            textBoxInput.Text = Convert.ToString(Ceill);

            history.Add($"ceil({lastInput}) = {Ceill}");
        }

        private void buttonTruncate_Click(object sender, EventArgs e)
        {
            string lastInput = textBoxInput.Text;

            double truncc = Convert.ToDouble(textBoxInput.Text);
            truncc = Math.Truncate(truncc);
            textBoxInput.Text = Convert.ToString(truncc);

            history.Add($"trunc({lastInput}) = {truncc}");
        }

        private bool isHistoryVisible = false;
        private int maxHeight = 400;
        private void labelHistory_Click(object sender, EventArgs e)
        {
            if (!isHistoryVisible)
            {
                if (history.Count > 0)
                {
                    textBoxInput.Multiline = true;
                    textBoxInput.ScrollBars = ScrollBars.Vertical;
                    textBoxInput.Font = new Font(textBoxInput.Font.FontFamily, 10);
                    textBoxInput.Text = string.Join(Environment.NewLine, history);


                    textBoxInput.Height = maxHeight;

                    textBoxInput.BringToFront();
                }
                else
                {
                    textBoxInput.Text = "No history available.";
                }
                isHistoryVisible = true;
            }
            else
            {
                {
                    textBoxInput.Multiline = false;
                    textBoxInput.Height = 50;
                    textBoxInput.Font = new Font(textBoxInput.Font.FontFamily, 24);
                    textBoxInput.Text = "0";
                    isHistoryVisible = false;

                    textBoxInput.SendToBack();
                }
            }
        }

        

        private void advance_basic_Click(object sender, EventArgs e)
        {
            bool isVisible = !buttonSinh.Visible; // If one is visible, toggle all

            buttonSinh.Visible = isVisible;
            buttonTanh.Visible = isVisible;
            buttonCosh.Visible = isVisible;
            buttonFloor.Visible = isVisible;
            buttonCeil.Visible = isVisible;
            buttonTruncate.Visible = isVisible;

            advance_basic.Text = isVisible ? "Basic" : "Advanced";

            if (isVisible)
            {
                this.Width = 480;  // Expanded width (Adjust as needed)
                textBoxInput.Width = 378; // Expanded text box width
                advance_basic.Left = 375; // Move label further left
            }
            else
            {
                this.Width = 400;  // Compressed width (Adjust as needed)
                textBoxInput.Width = 300; // Compressed text box width
                advance_basic.Left = 269; // Move label further left
            }

        }
    }
}
