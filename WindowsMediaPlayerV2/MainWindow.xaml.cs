using Microsoft.Win32;
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
using WindowsMediaPlayerV2.ViewModel;

namespace WindowsMediaPlayerV2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelBase(myMedia);
        }
    }
    public class CurrentMedia
    {

        List<string> listMediaName = new List<string>();
        public CurrentMedia()
        {
            
        }

        public void AddMedia(string toAdd)
        {
            listMediaName.Add(toAdd);
        }

        public string GetCurrentMedia()
        {
            return (listMediaName[0]);
        }

        public void NextMedia()
        {

        }

        public void PrevMedia()
        {

        }
        // list de string pour tout les filenames de la playlist
        // Methode next
        // Methode previous
        // serialization LINQ ??
    }
}
