using ButekoGOAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ButekoGOAPP.ViewModels
{
    public class PerfilViewModel : BaseViewModel
    {
        Perfil View;
        public PerfilViewModel(Perfil view)
        {
            this.View = view;

            IsBusy = false;

            Task.Run(async () => await this.GetPerfil());
        }

        public string Nome { get; set; }
        public int Points { get; set; }
        public int Rank { get; set; }
        public bool ReceberCupons { get; set; }
        public int RaioNotificacao { get; set; }
        public IEnumerable<Models.Marcas> ListMarcas { get; set; }
        public IEnumerable<string> ListDistancias { get; set; }
        public string LogoPoints { get; set; }

        public async Task GetPerfil()
        {
            IsBusy = true;

            var MyPerfil = new Models.Perfil()
            {
                Nome = "Marcus Paulo",
                Points = 785,
                Rank = 8,
                ReceberCupons = true,
                RaioNotificacao = 1,
                ListMarcas = new List<Models.Marcas>()
                {
                    { new Models.Marcas(){ Marca = "brahma", Points = 285 } },
                    { new Models.Marcas(){ Marca = "skol", Points = 150 } },
                    { new Models.Marcas(){ Marca = "budweiser", Points = 30 } },
                    { new Models.Marcas(){ Marca = "corona", Points = 15} },
                    { new Models.Marcas(){ Marca = "stellaartois", Points = 10} },
                    { new Models.Marcas(){ Marca = "antarticaSubzero", Points = 5} }
                },
                ListDistancias = new List<string> { "1 kilometro", "3 kilometros", "5 kilometros" }
            };

            await Task.Delay(500);            

            this.Nome = MyPerfil.Nome;
            OnPropertyChanged(nameof(this.Nome));

            this.Points = MyPerfil.Points;
            OnPropertyChanged(nameof(this.Points));

            this.Rank = MyPerfil.Rank;
            OnPropertyChanged(nameof(this.Rank));

            this.ReceberCupons = MyPerfil.ReceberCupons;
            OnPropertyChanged(nameof(this.ReceberCupons));

            this.RaioNotificacao = MyPerfil.RaioNotificacao;
            OnPropertyChanged(nameof(this.RaioNotificacao));

            this.ListMarcas = MyPerfil.ListMarcas;
            OnPropertyChanged(nameof(this.ListMarcas));

            this.ListDistancias = MyPerfil.ListDistancias;
            OnPropertyChanged(nameof(this.ListDistancias));

            this.LogoPoints = MyPerfil.LogoPoints;
            OnPropertyChanged(nameof(this.LogoPoints));

            IsBusy = false;
        }
    }
}
