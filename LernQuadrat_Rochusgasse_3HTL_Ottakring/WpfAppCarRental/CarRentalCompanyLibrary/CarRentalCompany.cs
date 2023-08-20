using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    /**
     * IDisposable:
     * 
     * Durch IDisposable kann CarRentalCompany innerhalb des using() Feldes verwendet werden.
     * Dadurch wird am Ende des usign() Feldes automatisch  public void Dispose() aufgerufen werden.
     * 
     * in Dispose() sollten dann alle offenen Resourcen (offene Files, DB-Connections) geschlossen werden
     */
    public class CarRentalCompany : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
