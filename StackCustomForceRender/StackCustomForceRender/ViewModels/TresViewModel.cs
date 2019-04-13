using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StackCustomForceRender.ViewModels
{
    public class TresViewModel : ViewModelBase
    {
        private ObservableCollection<string> _nomes;

        public ObservableCollection<string> Nomes
        {
            get { return _nomes; }
            set
            {
                _nomes = value;
                OnPropertyChanged();
            }
        }

        public TresViewModel()
        {
            Nomes = new ObservableCollection<string>()
            {
                "Sofia",
                "Isabella",
                "Camila",
                "Valentina",
                "Valeria",
                "Mariana",
                "Luciana",
                "Daniela",
                "Gabriela",
                "Victoria",
                "Martina",
                "Lucia",
                "Ximena/Jimena",
                "Sara",
                "Samantha",
                "Maria José",
                "Emma",
                "Catalina",
                "Julieta",
                "Mía",
                "Antonella",
                "Renata",
                "Emilia",
                "Natalia",
                "Zoe",
                "Nicole",
                "Paula",
                "Amanda",
                "María Fernanda",
                "Emily",
                "Antonia",
                "Alejandra",
                "Juana",
                "Andrea",
                "Manuela",
                "Ana Sofia",
                "Guadalupe",
                "Agustina",
                "Elena",
                "María",
                "Bianca",
                "Ariana",
                "Ivanna",
                "Abril",
                "Florencia",
                "Carolina",
                "Maite",
                "Rafaela",
                "Regina",
                "Adriana",
                "Michelle",
                "Alma",
                "Violeta",
                "Salomé",
                "Abigail",
                "Juliana",
                "Valery",
                "Isabel",
                "Montserrat",
                "Allison",
                "Jazmín",
                "Julia",
                "Lola",
                "Luna",
                "Ana",
                "Delfina",
                "Alessandra",
                "Ashley",
                "Olivia",
                "Constanza",
                "Paulina",
                "Rebeca",
                "Carla",
                "María Paula"
            };

            for (int i = 0; i < Nomes.Count; i++)
            {
                Nomes[i] = "Índice " + i + " - " + Nomes[i];
            }
        }
    }
}
