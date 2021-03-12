using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar
    {
        private int taxi_id;
        private DateTime indulas;
        private int idotartam;
        private double tavolsag;
        private double viteldij;
        private double borravalo;
        private string fizetes_modja;

        public int Taxi_id { get => taxi_id; set => taxi_id = value; }
        public DateTime Indulas { get => indulas; set => indulas = value; }
        public int Idotartam { get => idotartam; set => idotartam = value; }
        public double Tavolsag { get => tavolsag; set => tavolsag = value; }
        public double Viteldij { get => viteldij; set => viteldij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string Fizetes_modja { get => fizetes_modja; set => fizetes_modja = value; }

        public Fuvar(int taxi_id, DateTime indulas, int idotartam, double tavolsag, double viteldij, double borravalo, string fizetes_modja)
        {
            this.taxi_id = taxi_id;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetes_modja = fizetes_modja;
        }
    }
}
