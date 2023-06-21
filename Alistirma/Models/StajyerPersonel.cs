using UgurBuyuktekeliOdev.Models.Abstract;

namespace Alistirma.Models
{
    public class StajyerPersonel : BasePersonel
    {
        public double saat { get; set; }
        public double saatlik { get; set; }
        public StajyerPersonel(int _Id, string _Name, string _LastName,double _saat,double _saatlik) : base(_Id, _Name, _LastName)
        {
            saat=_saat;
            saatlik=_saatlik;
        }

       

        public virtual string IsımGetir()
        {
            return Name + " " + LastName;
        }

        public override int AylikHesapla()
        {
            int maas = Convert.ToInt32(saat * saatlik);
            return maas;

        }
    }
}
