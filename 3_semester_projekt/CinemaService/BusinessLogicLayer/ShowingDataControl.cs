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
        ShowingDatabaseAccess _sAccess;
        public ShowingDataControl(IConfiguration inConfiguration)
        {
            _showingAccess = new ShowingDatabaseAccess(inConfiguration);
            _sAccess = new ShowingDatabaseAccess(inConfiguration);
        }
        public int Add(Showing showing)
        {
            int insertedId;
            try {
                insertedId = _showingAccess.Create(showing);
            }
            catch {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int id)
        {
            bool wasOk;
            try
            {
                wasOk = _showingAccess.Delete(id);
            }
            catch
            {
                wasOk = false;
            }
            return wasOk;

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

        public Showing GetShowingViewById(int showingId)
        {
            Showing foundShowing;
            try
            {
                foundShowing = _sAccess.GetShowingById(showingId);
            }
            catch
            {
                foundShowing = null;
            }
            return foundShowing;
        }


        public bool Put(int id, List<Showing> entitiesToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
