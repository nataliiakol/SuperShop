using System;
using BusinessLogicLayer.Product;
using BusinessLogicLayer.Users;

namespace ApplicationLayer
{
    public class UI
    {
        static int parsedAnswer;
        public static string CurrentUserName { get; private set; }

        public static void DrawHeader()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("");
            Console.WriteLine("  Hello, welcome to the Super Shop!         ");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("");
        }

        public static string DrawLogin() {
            Console.WriteLine("Please enter your name");
            CurrentUserName = Console.ReadLine();
            return CurrentUserName;
        }

        public static string DrawChoisesToSelect() {
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
                    application.DeliverFoodProducts(neededFoodProducts);
                    int neededHealthCosmetics = ValidIntMessage("How many health cosmetics products do you want?");
                    application.DeliverHealthCosmetics(neededHealthCosmetics);
                    int neededMakeUp = ValidIntMessage("How many make-up products do you want?");
                    application.DeliverMakeUp(neededMakeUp);
                    application.LogUser(CurrentUserName, "delivery");

                    break;
                case 2:
                    Console.WriteLine("Please enter a product number that you want to find");
                    string productId = Console.ReadLine();
                    application.FindProducts(productId);
                    application.LogUser(CurrentUserName, "search");
                    break;
                case 3:
                    Console.WriteLine("Please enter a product number that you want to update");
                    productId = Console.ReadLine();
                    Console.WriteLine("Enter new name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter new description");
                    string description = Console.ReadLine();
                    application.UpdateProduct();
                    application.LogUser(CurrentUserName, "update");
                    break;
                case 4:
                    Console.WriteLine("Please, enter a product number that you want to delete");
                    application.DeleteProducts(Console.ReadLine());
                    application.LogUser(CurrentUserName, "delete");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please, write your choice - a number between 1-4");
                    break;
            }
        }

        public static void DrawLoginUI(Application application) {
            string userName;
            do {
                userName = DrawLogin();
            } while (!application.checkAdmin(userName));
        }

        public static void DrawInititalUi(Application application) {

            do {
                string answer = DrawChoisesToSelect();
                if (int.TryParse(answer, out parsedAnswer)) {
                    MainJob(application, parsedAnswer);
                }
                else {
                    DrawInititalUi(application);
                }
            } while (parsedAnswer != 0);
        }
    }
}