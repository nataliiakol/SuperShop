using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Partners
{
    internal interface IPartners
    {
        string Name { get; set; }
        string Address { get; set; }
        DateTime StartContractDate { get; set; }
        DateTime EndContractDate { get; set; }

        void EndContract();
    }
}
