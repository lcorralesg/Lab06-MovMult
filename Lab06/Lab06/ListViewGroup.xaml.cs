using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CicloGroup : ObservableCollection<AlumnosGroup>
    {
        public string Ciclo { get; set; }
        public CicloGroup(string ciclo)
            : base()
        {
            Ciclo = ciclo;
        }
        public CicloGroup(string ciclo, IEnumerable<AlumnosGroup> source)
            : base(source)
        {
            Ciclo = ciclo;
        }
    };
    
    public ObservableCollection<CicloGroup> AlumnosList { get; set; } = new ObservableCollection<CicloGroup>();

    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
            AlumnosList.add
        }
    }
}