using DesktopClient.ModelLayer;
using DesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.ControlLayer
{
    public class ShowingControl
    {
        ShowingServiceAccess _sAccess;

        public ShowingControl()
        {
            _sAccess = new ShowingServiceAccess();
        }

        public async Task<List<Showing>> GetAllShowings()
        {
            List<Showing> foundShowings = await _sAccess.GetShowings();
            return foundShowings;



        }


        public async Task<int> CreateShowing(int movieId, int theaterId, DateTime date) {
            Showing newShowing = new Showing(movieId, theaterId, date, date);
            int insertedId = -1;
            try {
                insertedId = await _sAccess.CreateShowing(newShowing);
            }
            catch (Exception) {
                insertedId = -1;
            }
            return insertedId;
        }
    }
}
