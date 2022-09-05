namespace Article;

class Article
{
    private string[,] words = new string[20, 2];

    public Article()
    {
        words[0, 0] = "Word";
        words[0, 1] = "Soz";
        words[1, 0] = "Understand";
        words[1, 1] = "Anlamaq";
        words[2, 0] = "Jump";
        words[2, 1] = "Tullanmaq";
        words[3, 0] = "Speed";
        words[3, 1] = "Suret";
        words[4, 0] = "Walk";
        words[4, 1] = "Gezmek";
        words[5, 0] = "Run";
        words[5, 1] = "Qacmaq";
        words[6, 0] = "Talk";
        words[6, 1] = "Danismaq";
        words[7, 0] = "Chat";
        words[7, 1] = "Sohbet etmek";
        words[8, 0] = "Milk";
        words[8, 1] = "Sut";
        words[9, 0] = "Mother";
        words[9, 1] = "Ana";
        words[10, 0] = "Father";
        words[10, 1] = "Ana";
        words[11, 0] = "Apple";
        words[11, 1] = "Alma";
        words[12, 0] = "Jump";
        words[12, 1] = "Tullanmaq";
        words[13, 0] = "Create";
        words[13, 1] = "Yaratmaq";
        words[14, 0] = "One";
        words[14, 1] = "1";
        words[15, 0] = "Write";
        words[15, 1] = "Yazmaq";
        words[16, 0] = "Effect";
        words[16, 1] = "Tesir";
        words[17, 0] = "Over";
        words[17, 1] = "Ustu";
        words[18, 0] = "Iron";
        words[18, 1] = "Demir";
        words[19, 0] = "Sun";
        words[19, 1] = "Gunes";
    }

    public string this[string index]
    {
        get
        {
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i,0] == index)
                {

                    return words[i, 1];
                }
            }

            throw new Exception("Word does not exist");
        }

    }

}

struct Product
{
    public Guid code { get; set; }
    public string? name { get; set; }
    public double price { get; set; }


    public Product(Guid code, string? name, double price)
    {
        this.code = code;
        this.name = name;
        this.price = price;
    }


    public static double operator+(Product p1, Product p2)
    {
        return p1.price + p2.price;
    }
    public static double operator-(Product p1, Product p2)
    {
        return p1.price + p2.price;
    }
    public static double operator*(Product p1, Product p2)
    {
        return p1.price * p2.price;
    }
    public static double operator/(Product p1, Product p2)
    {
        return p1.price / p2.price;
    }

    public static Product operator--(Product p1)
    {
        p1.price--;
        return p1;
    }

    public static Product operator++(Product p1)
    {
        p1.price--;
        return p1;
    }

    public static bool operator==(Product p1, Product p2)
    {
        return p1.code == p2.code;
    }

    public static bool operator!=(Product p1, Product p2)
    {
        return p1.code != p2.code;
    }
    public static bool operator>(Product p1, Product p2)
    {
        return p1.price > p2.price;
    }
    public static bool operator<(Product p1, Product p2)
    {
        return p1.price < p2.price;
    }
    public static bool operator>=(Product p1, Product p2)
    {
        return p1.price >= p2.price;
    }
    public static bool operator<=(Product p1, Product p2)
    {
        return p1.price <= p2.price;
    }
    


}

struct Client
{
    public Guid clientCode;
    public string? fullName;
    public string? address;
    public string? telephone;
    public int numberOfOrder;
    public int totalAmountOfOrders;

    public Client(Guid clientCode, string? fullName, string? address, string? telephone, int numberOfOrder, int totalAmountOfOrders)
    {
        this.clientCode = clientCode;
        this.fullName = fullName;
        this.address = address;
        this.telephone = telephone;
        this.numberOfOrder = numberOfOrder;
        this.totalAmountOfOrders = totalAmountOfOrders;
    }

    public static bool operator==(Client c1, Client c2)
    {
        return c1.fullName == c2.fullName || c1.clientCode == c2.clientCode;
    }
    public static bool operator!=(Client c1, Client c2)
    {
        return c1.fullName != c2.fullName || c1.clientCode != c2.clientCode;
    }
    

}
class Program
{
    static void Main()
    {
        Article article = new Article();
        string? data;
        while (true)
        {
            Console.WriteLine("Enter Word: ");
            data = Console.ReadLine();

            try
            {
                Console.WriteLine(article[data]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

}



