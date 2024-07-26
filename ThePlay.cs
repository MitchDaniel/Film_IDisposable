using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_11
{
    internal class ThePlay : IDisposable
    {
        public ThePlay(string title, string authorName, string genre, int year)
        {
            Title = title;
            AuthorName = authorName;
            Genre = genre;
            Year = year;
        }

        public string Title { set; get; }

        public string AuthorName { set; get; }

        public string Genre { set; get; }

        public int Year { set; get; }

        ~ThePlay() 
        {
            Console.WriteLine("Destructor");
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine("Освобождаю ресурсы.");
            }
            disposed = true;
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