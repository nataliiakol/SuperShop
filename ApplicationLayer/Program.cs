using SuperShop;

namespace ApplicationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application appInstance = new Application();
            UI.drawInititalUi(appInstance);
        }
    }
}
 