using System;

namespace SuperShop.Partners
{
    public abstract class Partners {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime StartContractDate { get; set; }
        public DateTime EndContractDate { get; set; }

        internal void EndContract() {
            EndContractDate=DateTime.Today;
        }
    }
}
