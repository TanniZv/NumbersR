using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NumbersR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        public void AddToText(string a)
        {
            Entry1.Text += a;
        }

        public void ButtonOneClick (object sender, EventArgs e)
        {
                AddToText("1");
        }

        public void ButtonTwoClick(object sender, EventArgs e)
        {
                AddToText("2");
        }

        public void ButtonThreeClick(object sender, EventArgs e)
        {
                AddToText("3");
        }

        public void ButtonFourClick(object sender, EventArgs e)
        {
                AddToText("4");
        }
        public void ButtonFiveClick(object sender, EventArgs e)
        {
                AddToText("5");
        }
        public void ButtonSixClick(object sender, EventArgs e)
        {
                AddToText("6");
        }
        public void ButtonSevenClick(object sender, EventArgs e)
        {
                AddToText("7");
        }
        public void ButtonEightClick(object sender, EventArgs e)
        {
                AddToText("8");
        }
        public void ButtonNineClick(object sender, EventArgs e)
        {
                AddToText("9");
            
        }
        public void ButtonZiroClick(object sender, EventArgs e)
        {
                AddToText("0");
        }

        public void ButtonDoClick (object sender, EventArgs e)
        {
            if (Label1.Text != "" )
            {

            }
            else
            {
                int n = Entry1.Text.Length;
                char[] mas = new char[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i] = Entry1.Text[i];
                }
                for (int i = n; i != 0; i--)
                {
                    Label1.Text += mas[i - 1];
                }

            }
        }

        public void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (Entry1.Text != null)
            {
                Label1.Text = "";
                Entry1.Text = "";

            }
        }



    }
}