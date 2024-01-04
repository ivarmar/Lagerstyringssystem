using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    public interface IProduct
    {
        string Name { get; set; }

        double Price { get; set; }

        void PrintInfo();


    }
}
