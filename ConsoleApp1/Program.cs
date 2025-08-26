//Задание 2: Сериализация коллекции объектов. 
//Создайте класс Product с полями, представляющими информацию о 
//продукте (название, цена, описание и т.д.). 
//Создайте список, содержащий несколько объектов класса Product. 
//Используйте System.Text.Json для сериализации списка продуктов в 
//JSON-массив. 
//Сохраните JSON-массив в файл.


using System.Text.Json;

class Program
{
    public static void Main(string[] args)
    {
        List<string> productList = new List<string>(3){"Чай-Утрин", "Кофе-Бодрин", "Какао-Позитивин"},
        List<float> productPrice = new List<float>(3){55.5f, 222.22f, 111.11f},
        List<string> productDescribe = new List<string>(3) { "чаёчек", "кофеёчек", "какао-какао-о-о-о" } ,
        };  
    }
}
public class Product
{
    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
}