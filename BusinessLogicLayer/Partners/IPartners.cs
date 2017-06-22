using System;

namespace BusinessLogicLayer.Partners
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
