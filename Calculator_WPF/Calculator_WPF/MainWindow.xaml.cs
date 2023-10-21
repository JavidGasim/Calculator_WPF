using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        string Operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "1";
            }
            else
            {
                label1.Content = label1.Content + "1";
            }
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "2";
            }
            else
            {
                label1.Content = label1.Content + "2";
            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "3";
            }
            else
            {
                label1.Content = label1.Content + "3";
            }
        }

        private void dord_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "4";
            }
            else
            {
                label1.Content = label1.Content + "4";
            }
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "5";
            }
            else
            {
                label1.Content = label1.Content + "5";
            }
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "6";
            }
            else
            {
                label1.Content = label1.Content + "6";
            }
        }

        private void yeddi_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "7";
            }
            else
            {
                label1.Content = label1.Content + "7";
            }
        }

        private void sekkiz_Click(object sender, EventArgs e)
        {
            if (label1.Content == "0" && label1.Content != null)
            {
                label1.Content = "8";
            }
            else
            {
                label1.Content = label1.Content + "8";
            }
        }

        private void doqquz_Click(object sender, EventArgs e)
        {
            if (label1.Content == "" && label1.Content != null)
            {
                label1.Content = "9";
            }
            else
            {
                label1.Content = label1.Content + "9";
            }
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            label1.Content = label1.Content + "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Content);
            label1.Content = "0";
            Operation = "+";
        }

        private void cixma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Content);
            label1.Content = "0";
            Operation = "-";

        }

        private void vurma_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Content);
            label1.Content = "0";
            Operation = "*";
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Content);
            label1.Content = "0";
            Operation = "/";
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            label1.Content = "0";
        }

        private void faiz_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Content);
            label1.Content = "0";
            Operation = "%";
        }

        private void noqte_Click(object sender, EventArgs e)
        {
            label1.Content = label1.Content + ".";
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(label1.Content);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                label1.Content = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                label1.Content = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                label1.Content = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    label1.Content = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    label1.Content = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber * SecondNumber) / 100;
                label1.Content = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}