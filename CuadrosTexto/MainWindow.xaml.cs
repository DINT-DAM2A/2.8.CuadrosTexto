using System;
using System.Windows;
using System.Windows.Input;

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (NombreAyudaTextBlock.Text.Length == 0)
                    NombreAyudaTextBlock.Text = "Nombre del cliente";
                else
                    NombreAyudaTextBlock.Text = "";
            }

        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (ApellidoAyudaTextBlock.Text.Length == 0)
                    ApellidoAyudaTextBlock.Text = "Apellido del cliente";
                else
                    ApellidoAyudaTextBlock.Text = "";
            }
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.F2)
            {
                if (Int32.TryParse(EdadTextBox.Text, out _))
                    EdadValidarTextBlock.Text = "";
                else
                    EdadValidarTextBlock.Text = "Edad incorrecta";
            }
        }
    }
}
