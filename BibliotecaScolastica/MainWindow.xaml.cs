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

namespace BibliotecaScolastica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("Mondadori", "Via romagna, 22", "13:00", "20:00");
            AggiornaListBoxLibri();
        }

        private void btn_aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro(txt_autore.Text, txt_titolo.Text, int.Parse(txt_dataPubblicazione.Text), txt_editore.Text, int.Parse(txt_numeroPagine.Text));
            biblioteca.AddLibro(libro);
        }
        public void AggiornaListBoxLibri()
        {
            lbx_informazioni.Items.Clear();
            foreach(Libro l in biblioteca.Libri)
            {
                lbx_listaLibri.Items.Add(l);
            }
        }

        private void lbx_listaLibri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbx_informazioni.Items.Clear();
            lbx_informazioni.Items.Add(lbx_listaLibri.SelectedItem.ToString());
        }

        private void btn_ricerca_Click(object sender, RoutedEventArgs e)
        {
            if(cbx_ricercaAutore.IsChecked == true)
            {
                biblioteca.ricercaTitolo(txt_ricerca.Text);
            }
            else
            {
                biblioteca.ricercaTitolo(txt_ricerca.Text);
            }
        }

        private void btn_tempoLettura_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_numeroLibri_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
