using System.Windows;

namespace ListaNombres
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

        // Metodo que agrega items a la lista.
        private void BtnAddName_click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Clear();
        }

        // Metodo que borra todos los items de la lista
        private void BtnDelNames_click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
        }

        // Metodo el cual borra el item seleccionado.
        private void BtnDelSelName_Clic(object sender, RoutedEventArgs e)
        {
            lstNames.Items.RemoveAt(lstNames.SelectedIndex);
        }
    }
}
