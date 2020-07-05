using System;
using System.Collections.Generic;
using System.Text;

namespace ButekoGOAPP.Models
{
    public class Perfil
    {
        public string Nome { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public bool ReceberCupons { get; set; }
        public int RaioNotificacao { get; set; }
        public string LogoPoints 
        { 
            get
            {
                if (Points == 0)
                    return "Beer0";
                else if (Points > 0 && Points <= 250)
                    return "Beer25";
                else if (Points > 250 && Points <= 750)
                    return "Beer75";
                else
                    return "Beer100";
            }
        }
        public IEnumerable<Marcas> ListMarcas { get; set; }
        public IEnumerable<string> ListDistancias { get; set; }
    }

    public class Marcas
    {
        public string Marca { get; set; }
        public int Points { get; set; }
    }    
}
