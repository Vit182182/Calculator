﻿using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        Boolean Multiply = false;
        Boolean Del = false;
        Boolean Plus = false;
        Boolean Minus = false;
        Boolean Clear = true;
        Double A;
        Double B;
        Double Result;
        Boolean Dot = false;
        public static int MouseHoverTime { get; } = 200;//Врем появления подсказки(мс)

        public MainForm()
        {
            InitializeComponent();
        }

        #region События кнопок 0-9
        private void B0_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("0");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("0");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {           
            if (OperationsIsClear())
            {
                ResultBox.AppendText("1");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("1");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("2");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("2");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("3");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("3");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("4");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("4");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("5");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("5");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("6");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("6");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("7");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("7");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("8");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("8");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                ResultBox.AppendText("9");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }

            else
            {
                ResultBox.AppendText("9");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }
        #endregion              

        #region Кнопки "=" и "C"
        private void BResult_Click(object sender, EventArgs e)
        {
            OperationBox.Clear();
            if (Multiply == true)
                Result = A * B;

            if (Del == true)
                Result = A / B;

            if (Plus == true)
                Result = A + B;

            if (Minus == true)
                Result = A - B;

            ResultBox.Text = Result.ToString();

            Multiply = false;
            Del = false;
            Plus = false;
            Minus = false;

            Clear = true;
        }

        private void BC_Click(object sender, EventArgs e)
        {
            OperationBox.Clear();
            ResultBox.Text = "0";
            Multiply = false;
            Del = false;
            Plus = false;
            Minus = false;
            Clear = true;
            A = 0;
            B = 0;
            Result = 0;
            Dot = false;
        }

        #endregion

        #region Кнопки операций +, -, *, /
        private void BDel_Click(object sender, EventArgs e)
        {
            OperationBox.Text = "/";
            Multiply = false;
            Del = true;
            Plus = false;
            Minus = false;
            Dot = true;
            ResultBox.Clear();

        }

        private void BMultiply_Click(object sender, EventArgs e)
        {
            OperationBox.Text = "*";
            Multiply = true;
            Del = false;
            Plus = false;
            Minus = false;
            Dot = true;
            ResultBox.Clear();
        }

        private void BMinus_Click(object sender, EventArgs e)
        {
            OperationBox.Text = "-";             
            Multiply = false;
            Del = false;
            Plus = false;
            Minus = true;
            Dot = true;
            ResultBox.Clear();
        }

        private void BPlus_Click(object sender, EventArgs e)
        {
            OperationBox.Text = "+";
            Multiply = false;
            Del = false;
            Plus = true;
            Minus = false;
            Dot = true;
            ResultBox.Clear();
        }

        #endregion

        //Запятая
        private void BDot_Click(object sender, EventArgs e)
        {
            if (OperationsIsClear())
            {
                if (Dot == false)
                {
                    ResultBox.AppendText(",");
                    Dot = true;
                }
            }

            else
            {
                if (Dot == true)
                {
                    ResultBox.AppendText(",");
                    Dot = false;
                }
            }

        }
        //Квадратный корень
        private void BSqrt_Click(object sender, EventArgs e)
        {
            OperationBox.Text = "sqrt";
            Result = Convert.ToDouble(ResultBox.Text);
            ResultBox.Text = Convert.ToString(Math.Sqrt(Result));
            A = Convert.ToDouble(ResultBox.Text);
        }

        //Округление
        private void BRound_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(ResultBox.Text);
            ResultBox.Text = Convert.ToString(Math.Round(Result));
            A = Convert.ToDouble(ResultBox.Text);
            
        }

        //Событие задержки мыши над кнопкой "~"       
        private void AboutBRound(object sender, EventArgs e)
        {
            BRound.Text = "Округлить";
        }

        //Событие ухода мыши с кнопки "~"    
        private void LeaveBRound(object sender, EventArgs e)
        {
            BRound.Text = "~";
        }        

        //Вспомогательная функция
        private bool OperationsIsClear()
        {
            if (Clear == true)
            {
                OperationBox.Clear();
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            return Multiply == false && Del == false && Plus == false && Minus == false;
        }
    }
}
