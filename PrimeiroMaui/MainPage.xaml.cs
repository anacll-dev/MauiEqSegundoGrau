namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            double a = double.Parse(txt_CoefA.Text);
            double b = double.Parse(txt_CoefB.Text);
            double c = double.Parse(txt_CoefC.Text);

            double delta = (b * b) - 4 * a * c;
            double raiz = Math.Sqrt(delta);

            double resx1 = (-b + raiz) / (2*a);
            double resx2 = (-b - raiz) / (2*a);

            string mensg = $" O resultado do x' é: " + resx1 + "\n O resultado do x'' é:" + resx2;
            DisplayAlert("Resultado", mensg, "Fechar");


        }
    }

}
