using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgurBuyuktekeliOdev.Models.Abstract
{
    public abstract class BasePersonel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public BasePersonel(int _Id, string _Name, string _LastName)
        {
            Id=_Id;
            Name=_Name;
            LastName=_LastName;
        }
        public virtual string IsımGetir() 
        {
            return Name + " " + LastName;
        }
        public virtual int AylikHesapla() 
        {
            return 0;
        }
    }
}
