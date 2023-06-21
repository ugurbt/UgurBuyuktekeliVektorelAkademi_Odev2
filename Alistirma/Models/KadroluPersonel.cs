using UgurBuyuktekeliOdev.Models.Abstract;

namespace Alistirma.Models
{
    public class KadroluPersonel : BasePersonel
    {
        public int Aylik { get; set; }
        public int Rapor { get; set; }
        public KadroluPersonel(int _Id, string _Name, string _LastName,int _Aylik, int _Rapor) : base(_Id, _Name, _LastName)
        {
            Aylik=_Aylik;
            Rapor=_Rapor;
        }

     

        public virtual string IsımGetir()
        {
            return Name + " " + LastName;
        }
        public override int AylikHesapla()
        {
            if (Rapor <= 5)
                return Aylik;
            else
                return Aylik - (Aylik / 30) * Rapor;

        }

    }
}
