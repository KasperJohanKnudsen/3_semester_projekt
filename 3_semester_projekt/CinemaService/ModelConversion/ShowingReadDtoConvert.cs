using CinemaData.ModelLayer;
using CinemaService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.ModelConversion
{
    public class ShowingReadDtoConvert
    {
        /*
        public static List<ShowingdataReadDto> FromShowingCollection(List<Showing> inShowings)
        {
            List<ShowingdataReadDto> aShowingReadDtoList = null;
            if (inShowings != null)
            {
                aShowingReadDtoList = new List<ShowingdataReadDto>();
                ShowingdataReadDto tempDto;
                foreach (Showing aShowing in inShowings)
                {
                    tempDto = FromShowing(aShowing);
                    aShowingReadDtoList.Add(tempDto);
                }
            }
            return aShowingReadDtoList;
        }
        public static ShowingdataReadDto FromShowing(Showing inShowing)
        {
            ShowingdataReadDto aShowingReadDto = null;
            if (inShowing != null)
            {
                aShowingReadDto = new ShowingdataReadDto("Citizen Kane", "Sal 1", inShowing.StartTime, inShowing.Date);
                aShowingReadDto.ShowingOrder = $"{"Citzen Kane"} {"Sal 1"} {inShowing.StartTime} {inShowing.Date}";

            }
            return aShowingReadDto;
        }
        */
    }
}
