using System.Collections;
using System.Collections.Generic;
using Models;

namespace HandIn1.Data
{
    public interface IAdultAdapter
    {
        public IList<Adult> getAllAdults();
        public void Delete(Adult adult);
        public void Add(Adult adult);
        public void Modify(Adult adult);

    }
}