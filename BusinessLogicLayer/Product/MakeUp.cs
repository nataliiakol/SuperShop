﻿namespace BusinessLogicLayer.Product
{
    public class MakeUp : Cosmetics {
        public override bool Validate() {
            return true;
        }

        public MakeUp() : base("03") { }
    }
}
