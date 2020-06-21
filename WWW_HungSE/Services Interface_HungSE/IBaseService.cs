using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interface_HungSE
{
   public interface IBaseService<T>where T:class

    {
        IEnumerable<T> GetAll();
        T getById(object id);
    }
}
