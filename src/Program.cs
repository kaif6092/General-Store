class Program
{
    static void Main()
    {
        int playerCoins = 6000;
        
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int milkshakePrice = 700; 

        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome to the general store!");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        while (playerCoins >= 0)         
        {
          Console.WriteLine("What would you like to purchase?");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet.");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");
        Console.WriteLine("E: A milkshake.");

        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your purchase: ");
        string purchaseLetter = Console.ReadLine();

        Console.WriteLine("");

        var shop = new Shop();

        switch (purchaseLetter) {
            case "A":
                playerCoins = shop.chargeForItem(playerCoins, shirtPrice);
                break;
            case "B":
                playerCoins = shop.chargeForItem(playerCoins, helmetPrice);
                break;
            case "C":
                playerCoins = shop.chargeForItem(playerCoins, foodPrice);
                break;
            case "D":
                playerCoins = shop.chargeForItem(playerCoins, presentPrice);
                break;
            case "E":    
                playerCoins = shop.chargeForItem(playerCoins, milkshakePrice);
                break;
        }
        }  

        }
    }

    public class Shop
    {
        // properties
        // TODO: list of items in the shop to go here E.g, List<ShopItem> Stock

        // constructor
        public Shop()
        {
            // TODO
        }

        // methods
        public int chargeForItem(int playerCoins, int itemPrice)
        {
            if (playerCoins >= itemPrice)
            {
                playerCoins = playerCoins - itemPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining."); 
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough coins to purchase this item!");
            }

            return playerCoins;
        }

    }


