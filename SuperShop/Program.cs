using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application appInstance = new Application();
            UI.drawInititalUi(appInstance);
        }
    }
}
