using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator_ver1
{
    public partial class Form_calculator : Form //Formクラスを継承
    {
        private bool Label_overwrite = true; //表示ラベルの上書き
        private bool Num_Plus = true; // +/- ボタンの正負判定
        private bool Num_Dot = false; // .ドット の有無判定
        private bool isFormatted = false;
        private double dNum; //ラベルをdouble型に格納する変数
        private double dNum_Pool; //ラベルの数字をプールする変数

        private enum MarksType //列挙子
        {
            NON,
            PLUS,
            MINUS,
            MULTIPLIED,
            DEVIDED,
            PERCENT,
        }
        private MarksType mType = MarksType.NON;
        public Form_calculator() //Form作成時に自動生成
        {
            InitializeComponent();
        }


        private void zero_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = zero.Text;
            }
            else
            {
                Num_Label.Text += zero.Text;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = one.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += one.Text;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = two.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += two.Text;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = three.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += three.Text;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = four.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += four.Text;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = five.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += five.Text;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = six.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += six.Text;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = seven.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += seven.Text;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = eight.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += eight.Text;
            }
        }



        private void nine_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = nine.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += nine.Text;
            }
        }

        private void all_clear_Click(object sender, EventArgs e)
        {
            Num_Label.Text = "0";
            Label_overwrite = true;
            Num_Dot = false;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (Num_Plus == true)
            {
                Num_Label.Text = "-" + Num_Label.Text;
                Num_Plus = false;
            }
            else
            {
                Num_Label.Text = Num_Label.Text.Replace("-", "");
                Num_Plus = true;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (Num_Dot == false)
            {
                Num_Label.Text = Num_Label.Text + ".";
                Num_Dot = true;
                Label_overwrite = false;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Num_Dot = false;
            Label_overwrite = true;
            Num_PoolMethod();
            mType = MarksType.PLUS;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Num_Dot = false;
            Label_overwrite = true;
            Num_PoolMethod();
            mType = MarksType.MINUS;
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            Num_Dot = false;
            Label_overwrite = true;
            Num_PoolMethod();
            mType = MarksType.MULTIPLIED;
        }

        private void divided_Click(object sender, EventArgs e)
        {
            Num_Dot = false;
            Label_overwrite = true;
            Num_PoolMethod();
            mType = MarksType.DEVIDED;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            Num_Dot = false;
            Label_overwrite = true;
            mType = MarksType.PERCENT;
            Num_PoolMethod();
            mType = MarksType.NON;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Num_PoolMethod();
            mType = MarksType.NON;
            Num_Dot = false;
            Label_overwrite = true;
        }
        private void Num_PoolMethod()// ＋ ー × ÷ ％ 演算子の計算処理
        {
            dNum = double.Parse(Num_Label.Text);
            switch (mType)
            {
                case MarksType.NON:
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS:
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DEVIDED:
                    dNum_Pool /= dNum;
                    break;
                case MarksType.PERCENT:
                    dNum_Pool = dNum * 0.01;
                    break;
            }
            Num_Label.Text = dNum_Pool.ToString();
        }

        private void mark_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (Num_Label.Text.Length > 0)
            {
                Num_Label.Text = Num_Label.Text.Remove(Num_Label.Text.Length - 1);
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            double number = double.Parse(Num_Label.Text);
            if (!isFormatted)
            {
                string formatted = string.Format("{0:#,0}", number);
                Num_Label.Text = formatted;
                isFormatted = true;
            }
            else
            {
                string unformatted = string.Format("{0}", number);
                Num_Label.Text = unformatted;
                isFormatted = false;
            }
        }
    }
}