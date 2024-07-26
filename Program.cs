namespace CSharp_HW_modul_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ThePlay Toska = new ThePlay("Toska", "Jackomi Puchini", "Opera", 1885))
            {
                Console.WriteLine(Toska.AuthorName);
            }

        }
    }
}
//Создайте класс Пьеса. Класс должен хранить такую информацию:
//• Название пьесы
//• ФИО автора
//• Жанр
//• Год выпуска
//Реализуйте B классе методы И свойства, необходимые для функционирования класса.
//Добавьте в классе деструктор. Напишите код для тестирования функциональности класса.
//Напишите код для вызова деструктора.