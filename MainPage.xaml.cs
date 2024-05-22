using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadorabasica3
{
    public partial class MainPage : ContentPage
    {
        int numero_1;
        int numero_2;
        string ope_;
        double operation_result = 0;

        public MainPage()
        {
            InitializeComponent();
            pickerope.Items.Add("Suma ( + )");
            pickerope.Items.Add("Resta ( - )");
            pickerope.Items.Add("Multiplicación ( X )");
            pickerope.Items.Add("División ( / )");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Pickerope_SelectedIndexChanged(object sender, EventArgs e)
        {
            ope_ = pickerope.SelectedItem.ToString();
            numero_1 = int.Parse(txtnum1.Text);
            numero_2 = int.Parse(txtnum2.Text);
        }

        private void Btnoperation_Clicked(object sender, EventArgs e)
        {
            if (ope_ == "Suma ( + )")
            {
                operation_result = numero_1 + numero_2;
            }
            else if (ope_ == "Resta ( - )")
                operation_result = numero_1 - numero_2;
            else if (ope_ == "Multiplicación ( X )")
                operation_result = numero_1 * numero_2;
            else
                operation_result = (numero_1 / numero_2);

            lblresult.Text = operation_result + "";
        }
    }
}
