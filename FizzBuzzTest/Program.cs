/*
Часть 1.
	Основное требование - необходимо организовать структуру классов таким образом, 
        чтобы функционал можно было легко расширять и вносить изменения.
		
	1. В приложение приходит коллекция значений от 0 до 17 которые необходимо преобразовать.

	2. Значения кратные 3 заменяем на слово "Fizz", а значения кратные 5 на слово "Buzz". 
		Если занчение кратно и 3 и 5 заменяем на слово "FizzBuzz". Отсутствующие совпадения отбрасываем. 

	3. Полученный результат необходимо вывести в консоль.


После реализации, необходимо будет расширить функционал. 
Закомментированный код относится ко второй части задания.
*/

using FizzBuzzTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection1 = GetTestData.GetTestData1(17);

            var result = new ViewResult(collection1);

            result.ViewResultCollection.ToList().ForEach(x => Console.WriteLine(x.MessageBody));

            //var collection2 = GetTestData.GetTestData1(21);
            //var collection3 = GetTestData.GetTestData2();

            // todo: You are welcome
            Console.ReadLine();
        }
    }
}
