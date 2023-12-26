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
using System.Windows.Threading;

namespace XAML_Prueba.Views
{
    /// <summary>
    /// Lógica de interacción para BienvenidaView.xaml
    /// </summary>
    public partial class BienvenidaView : Page
    {
        private readonly DispatcherTimer colorTimer;
        private readonly Brush[] colors = { Brushes.Red, Brushes.Blue, Brushes.Green }; // Lista de colores

        private int colorIndex = 0;
        public BienvenidaView()
        {
            InitializeComponent();

            colorTimer = new DispatcherTimer();
            colorTimer.Interval = TimeSpan.FromSeconds(1);
            colorTimer.Tick += ColorTimer_Tick;
            colorTimer.Start();
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            TextBlock textoBienvenida = Boton_Bienvenida;

            if (textoBienvenida != null)
            {
                textoBienvenida.Foreground = colors[colorIndex];

                colorIndex++;
                if (colorIndex >= colors.Length)
                {
                    colorIndex = 0;
                }
            }
        }     

        private void Boton_Bienvenida_Click(object sender, RoutedEventArgs e)
        {
            OpcionesView opcionesView = new OpcionesView();

            if (NavigationService != null)
            {
                NavigationService.Navigate(opcionesView);
            }
        }
    }
}
