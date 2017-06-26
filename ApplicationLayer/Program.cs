using BusinessLogicLayer.Product;

namespace ApplicationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application appInstance = new Application();

            UI.DrawHeader();
            UI.DrawLoginUI(appInstance);
            UI.DrawInititalUi(appInstance);
        }
    }
}
 