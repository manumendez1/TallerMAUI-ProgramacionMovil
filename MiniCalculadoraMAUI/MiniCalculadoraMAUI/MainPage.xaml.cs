namespace MiniCalculadoraMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(numero1Entry.Text) ||
                string.IsNullOrWhiteSpace(numero2Entry.Text))
            {
                resultadoLabel.Text = "⚠️ Ingresa ambos números";
                resultadoLabel.TextColor = Colors.Orange;
                resultadoBorder.IsVisible = true;
                return;
            }

            if (operacionPicker.SelectedIndex == -1)
            {
                resultadoLabel.Text = "⚠️ Selecciona una operación";
                resultadoLabel.TextColor = Colors.Orange;
                resultadoBorder.IsVisible = true;
                return;
            }

            double num1 = double.Parse(numero1Entry.Text);
            double num2 = double.Parse(numero2Entry.Text);
            double resultado = 0;

            switch (operacionPicker.SelectedIndex)
            {
                case 0: resultado = num1 + num2; break;
                case 1: resultado = num1 - num2; break;
                case 2: resultado = num1 * num2; break;
                case 3:
                    if (num2 == 0)
                    {
                        resultadoLabel.Text = "⚠️ División entre cero";
                        resultadoLabel.TextColor = Colors.Red;
                        resultadoBorder.IsVisible = true;
                        return;
                    }
                    resultado = num1 / num2;
                    break;
            }

            resultadoLabel.Text = $"{resultado:F2}";
            resultadoLabel.TextColor = Color.FromArgb("#1E88E5");
            resultadoBorder.IsVisible = true;
        }
        catch
        {
            resultadoLabel.Text = "⚠️ Error en los datos";
            resultadoLabel.TextColor = Colors.Red;
            resultadoBorder.IsVisible = true;
        }
    }
}