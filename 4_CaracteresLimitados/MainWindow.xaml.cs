using System.Windows;
using System.Windows.Controls;

namespace _4_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int MAXIMA_LONGITUD_TEXTO = 140;
        public MainWindow()
        {
            InitializeComponent();
            contadorTextBlock.Text = "0/" + MAXIMA_LONGITUD_TEXTO;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int longitud = textoTextBox.Text.Length;
            contadorTextBlock.Text = longitud + "/" + MAXIMA_LONGITUD_TEXTO;
            if (longitud >= MAXIMA_LONGITUD_TEXTO)
                textoTextBox.IsReadOnly = true;
        }
    }
}
