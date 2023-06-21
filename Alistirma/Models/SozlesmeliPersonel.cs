using UgurBuyuktekeliOdev.Models.Abstract;

namespace Alistirma.Models
{
    public class SozlesmeliPersonel : BasePersonel
    {
        public Double gun { get; set; }
        public Double gunluk { get; set; }

        public SozlesmeliPersonel(int _Id, string _Name, string _LastName, double _gun, double _gunluk) : base(_Id, _Name, _LastName)
        {
            gun = _gun;
            gunluk=_gunluk;
           
        }

       

        public virtual string IsımGetir()
        {
            return Name + " " + LastName;
        }

        public override int AylikHesapla()
        {
            int maas=Convert.ToInt32(gun*gunluk);
            return maas;
        }
    }
}
