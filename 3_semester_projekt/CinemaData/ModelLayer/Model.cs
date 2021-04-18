using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public abstract class Model
    {
        public int ID { get; set; }

        public delegate int IntDelegate(Model model);


        public int FindIdInList(IEnumerable<Model> propertyList)
        {
            int foundInt = GetFirstFoundInt(propertyList, GetId);
            return foundInt;
        }

        public int GetId(Model model)
        {
            return model.ID;
        }

        public int GetFirstFoundInt(IEnumerable<Model> propertyList, IntDelegate intFinder)
        {
            int tempInt = -1;
            foreach (Model entity in propertyList)
            {
                tempInt = intFinder(entity);
                return tempInt;
            }

            return tempInt;
        }
    }
}
