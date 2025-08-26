//Задание 1: Сериализация объекта в JSON. 
//Создайте класс Person с полями, представляющими информацию о 
//человеке (имя, фамилия, возраст, адрес, e-mail, дата рождения). 
//Создайте экземпляр этого класса, заполните его данными. 
//Используйте библиотеку System.Text.Json для сериализации объекта Person 
//в формат JSON. 
//Сохраните JSON-строку в файл. 

using System.Text.Json;
using System.Text.Encodings.Web;



class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person()
        {
            Name = "Вася",
            Surname = "Иванов",
            Age = 20,
            Mail = "vasya@mail.ru",
            DateOfBirth = new DateTime(2000, 09, 01)
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

        string personJson = JsonSerializer.Serialize(person, options);
        StreamWriter file = File.CreateText("person.json");
        file.WriteLine(personJson);
        file.Close();
    }
}

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Mail { get; set; }
    public DateTime DateOfBirth { get; set; }
}