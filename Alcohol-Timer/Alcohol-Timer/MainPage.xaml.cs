using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Alcohol_Timer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            DatePicker picker = Picker;
            DateTime date = picker.Date;
            DateTime currentDT = DateTime.Now;
            TimeSpan ts = currentDT.Subtract(date);
            TimeSpan drinkingAge = new TimeSpan(7671, 0, 0, 0);

            if (date == null)
            {
                Lbl_Date.Text = "No date";
            }
            else
            {
                if(ts >= drinkingAge){
                    Lbl_Date.Text = $"You can already drink alcohol";
                }
                else
                {
                    Lbl_Date.Text = $"You can drink alcohol in {(drinkingAge.Subtract(ts).TotalDays/365).ToString("F0")} Years";
                }
            }
        }
    }
}
