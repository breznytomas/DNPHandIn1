using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace HandIn1.Data
{
    public class AdultAdapter: IAdultAdapter
    {
        private FileContext _fileContext;
        public IList<Adult> adults; 
        
       public AdultAdapter()
        {
            _fileContext = new FileContext();
            adults = _fileContext.Adults;

        }


        public IList<Adult> getAllAdults()
        {
            return new List<Adult>(adults);
        }

        public void Delete(Adult adult)
        {

            adults.Remove(adult);
            _fileContext.SaveChanges();
        }

        public void Add(Adult adult)
        {

            try
            {
                adult.Id = adults.Max(adult => adult.Id);
                adult.Id++;
            }
            catch (Exception e)
            {
                adult.Id = 1;
            }
            
            adults.Add(adult);
            _fileContext.SaveChanges();
            
        }

        public void Modify(Adult adult)
        {
           
        }
    }
}