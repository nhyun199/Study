using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentoperators = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(Display.Text);

            if(currentoperators == Operators.Add)
            {
                firstOperand += secondOperand;
                Display.Text = firstOperand.ToString();
            }

            else if (currentoperators == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                Display.Text = firstOperand.ToString();
            }

            else if (currentoperators == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                Display.Text = firstOperand.ToString();
            }

            else if (currentoperators == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    Display.Text = "0으로 나눌 수 없습니다.";
                }

                else
                {
                    firstOperand /= secondOperand;
                    Display.Text = firstOperand.ToString();
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentoperators = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentoperators = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentoperators = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentoperators = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentoperators = Operators.None;
            Display.Text = "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }

            string strNunber = Display.Text += "0";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }

            string strNunber = Display.Text += "1";
            // "1" 버튼을 누르면 "01"이 저장됨.

            int intNumber = Int32.Parse(strNunber);
            // 저장된 "01" 문자열을 정수 형태로 변환함.

            Display.Text = intNumber.ToString();
            // 정수로 변환된 숫자를 Display에 적용함.
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "2";         
            int intNumber = Int32.Parse(strNunber);            
            Display.Text = intNumber.ToString();            
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "3";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "4";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "5";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "6";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "7";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "8";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNunber = Display.Text += "9";
            int intNumber = Int32.Parse(strNunber);
            Display.Text = intNumber.ToString();
        }
    }
}
