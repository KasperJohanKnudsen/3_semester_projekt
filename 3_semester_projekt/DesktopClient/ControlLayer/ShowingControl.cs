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

        public async Task<bool> Delete(int showingId)
        {
            bool wasUpdatedOk = false;
            ShowingServiceAccess sService = new ShowingServiceAccess();
            try
            {
                wasUpdatedOk = await sService.DeleteShowing(showingId);
            }
            catch (Exception)
            {
                wasUpdatedOk = false;
            }
            return wasUpdatedOk;
        }
    }
}
