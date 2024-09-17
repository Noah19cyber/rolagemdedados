
using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public class Dado
        {
            private int qtdDeLados;
            public int QtdDeLados { get => qtdDeLados; set => qtdDeLados = value; }
            public int RolarDado()
            {
                return new Random().Next(1, qtdDeLados + 1);
            }
        }

        private void DrawButton_Clicked(object sender, EventArgs e)
        {
            int qtdDados = Convert.ToInt32(DiceEntry.Text.ToString());
            int soma = 0;
            int resultado;
            String exibir = null;

            for (int cont = 0; cont < qtdDados; cont++)
            {
                int value = Convert.ToInt32(SidePicker.SelectedItem.ToString());
                int numeroSorteado = new Random().Next(1, value + 1);
                ResultLabel.Text = numeroSorteado.ToString();


                Dado dado = new Dado();
                int ItemPicker = Convert.ToInt32(SidePicker.SelectedItem.ToString());
                dado.QtdDeLados = ItemPicker;
                resultado = dado.RolarDado();
                soma = soma + resultado;

                exibir = exibir + resultado + " , ";

                ModLabel.Text = "Você tirou: " + exibir.ToString();
                ResultLabel.Text = soma.ToString();
            }

        
       }
    }

}
