using System;

namespace SuperShop.Partners
{
    public abstract class Partners : IPartners {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime StartContractDate { get; set; }
        public DateTime EndContractDate { get; set; }

        public void EndContract() {
            EndContractDate=DateTime.Today;
        }
    }
}
