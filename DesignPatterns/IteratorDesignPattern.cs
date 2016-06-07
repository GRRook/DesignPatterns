using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionNoLambda;

namespace DesignPatterns
{
    public interface Iterator<T>
    {
        Option<T> GetNext();
    }

    class NaturalList : Iterator<int>
    {
        private int current = -1;

        public Option<int> GetNext()
        {
            current++;
            return new Some<int>(current);
        }
    }

    class IterableList<T> : Iterator<T>
    {
        public Option<T> GetNext()
        {
            throw new NotImplementedException();
        }
    }


}
