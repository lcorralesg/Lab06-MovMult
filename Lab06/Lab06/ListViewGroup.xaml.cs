using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class EstudianteViewModel
    {
        public ObservableCollection<Estudiante> Estudiantes { get; set; }

        public EstudianteViewModel()
        {
            Estudiantes = new ObservableCollection<Estudiante>
            {

            };
        }
    }
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
            // Datos de ejemplo
            var estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Juan", Apellido = "Perez", Edad = 20, Promedio = 18.5, Ciclo = 3 },
                new Estudiante { Nombre = "Maria", Apellido = "Gomez", Edad = 22, Promedio = 17.5, Ciclo = 4 },
                new Estudiante { Nombre = "Luis", Apellido = "Hernandez", Edad = 21, Promedio = 19.5, Ciclo = 3 },
                new Estudiante { Nombre = "Ana", Apellido = "Torres", Edad = 19, Promedio = 16.5, Ciclo = 2 },
                new Estudiante { Nombre = "Pedro", Apellido = "Jimenez", Edad = 20, Promedio = 18.0, Ciclo = 4 },

            };

            var gruposEstudiantes = estudiantes.GroupBy(e => e.Ciclo)
                .Select(g => new GrupoEstudiantes(g.Key, g.ToList()))
                .ToList();

            EstudiantesView.ItemsSource = gruposEstudiantes;
        }
        public class GrupoEstudiantes : List<Estudiante>
        {
            public int Ciclo { get; private set; }

            public GrupoEstudiantes(int ciclo, List<Estudiante> estudiantes) : base(estudiantes)
            {
                Ciclo = ciclo;
            }
        }
    }
}