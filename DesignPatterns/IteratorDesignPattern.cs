using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionLambda;
namespace DesignPatterns
{
    public interface Iterator<T>
    {
        Option<T> GetNext();
    }

    class Iterablelist<T> : Iterator<T>
    {
        private List<T> list;
        public Iterablelist(List<T> list)
        {
            this.list = list;
        }

        public Option<T> GetNext()
        {
            throw new NotImplementedException();
            
        }
    }

}
