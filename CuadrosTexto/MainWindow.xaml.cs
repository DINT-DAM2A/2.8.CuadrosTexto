using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            if (e.Key.ToString().Equals("F1"))
            {
                if (NombreAyudaTextBlock.Text.Length == 0)
                    NombreAyudaTextBlock.Text = "Nombre del cliente";
                else
                    NombreAyudaTextBlock.Text = "";
            }

        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString().Equals("F1"))
            {
                if (ApellidoAyudaTextBlock.Text.Length == 0)
                    ApellidoAyudaTextBlock.Text = "Apellido del cliente";
                else
                    ApellidoAyudaTextBlock.Text = "";
            }
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            int num;

            if (e.Key.ToString().Equals("F2"))
            {
                if (Int32.TryParse(EdadTextBox.Text, out num))
                    EdadValidarTextBlock.Text = "";
                else
                    EdadValidarTextBlock.Text = "Edad incorrecta";
            }
        }
    }
}
