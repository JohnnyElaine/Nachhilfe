using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    public interface IPermanentable
    {
        void Load(string path);


        void Save(string path)
        {

        }
    }
}
