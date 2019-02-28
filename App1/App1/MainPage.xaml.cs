using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Presione.Clicked += Presione_Clicked;
            Digite_Número.Text += Digite_Número;
            Captura.Text += Captura;
           



        }

        
        

        private void Presione_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Ha dado click");
            Console.ReadLine(Captura);

        }
    }
}
