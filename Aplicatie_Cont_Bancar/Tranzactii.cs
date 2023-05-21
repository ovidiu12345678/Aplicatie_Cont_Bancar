using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Cont_Bancar
{
    internal class Tranzactii
    {
        private readonly int soldCurent = 600;
        private readonly int dataTranzactie;
        private readonly int oraTranzactie;

        public Tranzactii(int soldCurent, int dataTranzactie, int oraTranzactie)
        {
            this.soldCurent = soldCurent;
            this.dataTranzactie = dataTranzactie;
            this.oraTranzactie = oraTranzactie;
        }

        public string TiparesteDateTranzactiiContCurent()
        {
            string detaliiDateTranzactiiContCurent = $"Buna ziua ! Soldul contului dvs este de {soldCurent} lei";

            return detaliiDateTranzactiiContCurent;
        }

        public int DepunereBaniInContCurent(int soldCurent, int baniDepusi)
        {
            int depuneSoldInContCurent = soldCurent + baniDepusi;

            return depuneSoldInContCurent;
        }
        
        public string TiparesteDateTranzactiiDepunreBaniContCurent()
        {
            string informatiiDepunereBani = $"Felicitari, tocmai ati alimentat la contul curent suma de {soldCurent} roni in data de {dataTranzactie}, la intervalul orar {oraTranzactie}";
            return informatiiDepunereBani;
        }

        public int RetragereBaniContCurent(int soldCurent, int baniRetrasi)
        {
            if(soldCurent == 0 || soldCurent < baniRetrasi)
            {
                Console.WriteLine("Fonduri insuficente ! ");
            }
            else if(baniRetrasi == 0 || baniRetrasi > soldCurent)
            {
                Console.WriteLine($"Nu aveti fonduri suficiente ! Ati incercat sa retrageti o suma mai mare cat sodul initial pe care il detineti in contul dvs. Bani cont curent {soldCurent}");
            }
            else if(baniRetrasi < 50)
            {
                Console.WriteLine("Puteti retrage doar bani mutiplu de 50. Puteti scoate minim 50 ron ! Incercati din nou ! ");
            }
            else
            {
                Console.WriteLine($"Felicitari, ati retras cu succes suma de {baniRetrasi} si ati mai ramas cu sold curent {soldCurent} de roni");
            }
            int retrageBaniContCurent = soldCurent - baniRetrasi;
            return retrageBaniContCurent;
        }

        public string TiparesteDateRetragereBaniContCurent()
        {
            string afisareMwsajInformatiiRetragere = $"Felicitari, tocmai ati retras din  contul curent suma de {soldCurent} roni in data de {dataTranzactie}, la intervalul orar {oraTranzactie} ";

            return afisareMwsajInformatiiRetragere;
        }
    }
}
