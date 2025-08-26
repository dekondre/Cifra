//Задание 2: Сериализация коллекции объектов. 
//Создайте класс Product с полями, представляющими информацию о 
//продукте (название, цена, описание и т.д.). 
//Создайте список, содержащий несколько объектов класса Product. 
//Используйте System.Text.Json для сериализации списка продуктов в 
//JSON-массив. 
//Сохраните JSON-массив в файл.


using System.Text.Encodings.Web;
using System.Text.Json;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> productList = new List<Product>()
        {
            new Product() { Name = "Чай-Утрин", Price = 55.5f, Description = "чаёчек" },
            new Product() { Name = "Кофе-Бодрин", Price = 222.2f, Description = "кофеёчек" },
            new Product() { Name = "Какао-Позитивин", Price = 111.1f, Description = "какао-какао-о-о-о" }
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString,
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        string productsJson = JsonSerializer.Serialize(productList, options);
        StreamWriter file = File.CreateText("productList.json");
        file.WriteLine(productsJson);
        file.Close();
    }



    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}