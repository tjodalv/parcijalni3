using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Surfaj(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return $"URL {url} je ispravan.";
            }

            return "Neispravan URL!";
        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                return $"Zovem: {telefonski_broj}";
            }

            return "Neispravan telefonski broj!";
        }

        private bool ProvjeriAkoJeValidanUrl(string url)
        {
            return !url.Any(char.IsDigit);
        }

        private bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            return telefonski_broj.All(char.IsDigit);
        }
    }
}
