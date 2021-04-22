using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public class ShowingDataControl : IDataControl<Showing>
    {
        ICRUD<Showing> _showingAccess;
        public ShowingDataControl(IConfiguration inConfiguration)
        {
            _showingAccess = new ShowingDatabaseAccess(inConfiguration);
        }
        public int Add(Showing entityToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Showing GetById(int id)
        {
            Showing foundShowing;
            try
            {
                foundShowing = _showingAccess.GetById(id);
            }
            catch
            {
                foundShowing = null;
            }
            return foundShowing;
        }

        public IEnumerable<Showing> Get()
        {
            List<Showing> foundShowings;
            try
            {
                foundShowings = (List<Showing>)_showingAccess.GetAll();
            }
            catch
            {
                foundShowings = null;
            }
            return foundShowings;
        }

        public bool Put(Showing entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
