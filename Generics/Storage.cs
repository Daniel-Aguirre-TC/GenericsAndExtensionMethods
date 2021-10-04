using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Storage <T> where T : IStorable
    {

        public Storage()
        {
            Bin = new List<T>();
        }

        public List<T> Bin { get; set; }

        public Storage(List<T> items)
        {
            Bin = items;
        }


    }
}
