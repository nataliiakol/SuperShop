using ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace SuperShop
{
    public class UI
    {
        static int parsedAnswer;
        public static string DrawHeader()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("");
            Console.WriteLine("  Hello, welcome to the Super Shop!         ");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("");
            Console.WriteLine("Please select an action to perform:");
            Console.WriteLine("");
            Console.WriteLine("1. Deliver new products to the shop");
            Console.WriteLine("2. Find a product");
            Console.WriteLine("3. Update a product");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please, write your choice - a number between 0-4");
            return Console.ReadLine();
        }

        public static int ValidIntMessage(string message) {
            string answer;
            int parsedAnswer;
            do {
                Console.WriteLine(message);
                answer = Console.ReadLine();
            } while ((int.TryParse(answer, out parsedAnswer))==false);
            return parsedAnswer;
        }

        public static void MainJob(Application application, int parsedAnswer) {
            switch (parsedAnswer)
            {
                case 1:
                    int neededFoodProducts = ValidIntMessage("How many food products do you want?");
                    int neededHealthCosmetics = ValidIntMessage("How many health cosmetics products do you want?");
                    int neededMakeUp = ValidIntMessage("How many make-up products do you want?");
                    application.DeliverGoods(neededFoodProducts, neededHealthCosmetics, neededMakeUp);
                    break;
                case 2:
                    int productId = ValidIntMessage("Please enter a product number that you want to find");
                    application.FindProducts(productId);
                    break;
                case 3:
                    productId = ValidIntMessage("Please enter a product number that you want to update");
                    Console.WriteLine("Enter new name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter new description");
                    string description = Console.ReadLine();
                    application.UpdateProduct(productId, name, description);
                    break;
                case 4:
                    productId = ValidIntMessage("Please enter a product number that you want to delete");
                    int instanceCount = ValidIntMessage("Please enter how many items of this product do you want to delete");
                    application.DeleteProducts(productId, instanceCount);
                    break;
                default:
                    Console.WriteLine("Please, write your choice - a number between 1-4");
                    break;
            }
        }

        public static void drawInititalUi(Application application) {

            do {
                string answer = DrawHeader();
                if (int.TryParse(answer, out parsedAnswer)) {
                    MainJob(application, parsedAnswer);
                }
                else {
                    drawInititalUi(application);
                }
            } while (parsedAnswer != 0);
        }
    }
}
