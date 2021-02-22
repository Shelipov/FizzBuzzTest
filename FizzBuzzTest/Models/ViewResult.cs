using FizzBuzzTest.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Models
{
    public class ViewResult
    {
        public ViewResult(IEnumerable<int> query,bool flag = true)
        {
            Flag = flag;
            ViewResultCollection = new List<Message>();

                query.ToList().ForEach(x =>
                {
                    Message check = GetMessage(x);
                    if (!(check is null))
                        ViewResultCollection.Add(check);
                });
            WriteLine();
        }

        public ViewResult(IEnumerable<string> query)
        {
            Flag = false;
            ViewResultCollection = new List<Message>();

            query.ToList().ForEach(x =>
            {
                Message check = GetMessage(DataAlgorithm.Execute(x));
                if (!(check is null))
                    ViewResultCollection.Add(check);
            });
            WriteLine();
        }

        bool Flag { get; set; }
        ICollection<Message> ViewResultCollection { get; set; }

        Message GetMessage(int number)
        {
            switch (Flag ? DataAlgorithm.ExecuteFirstTask(number) : DataAlgorithm.ExecuteLastTask(number))
            {
                case "FizzBuzz":
                    return new Message()
                    {
                        MessageBody = MessageBodyEnum.FizzBuzz.GetValueAttribute(),
                        Number = number,
                        LastChangedOn = DateTime.UtcNow
                    };
                case "Fizz":
                    return new Message()
                    {
                        MessageBody = MessageBodyEnum.Fizz.GetValueAttribute(),
                        Number = number,
                        LastChangedOn = DateTime.UtcNow
                    };
                case "Buzz":
                    return new Message()
                    {
                        MessageBody = MessageBodyEnum.Buzz.GetValueAttribute(),
                        Number = number,
                        LastChangedOn = DateTime.UtcNow
                    };
                default:
                    Message result = null; 
                    if(!Flag)
                    {
                        result = new Message()
                        {
                            MessageBody = number.ToString(),
                            Number = number,
                            LastChangedOn = DateTime.UtcNow
                        };
                    }
                    return result;
            }
        }

        void WriteLine()
        {
            if (Flag)
            {
                ViewResultCollection.ToList().ForEach(x => Console.WriteLine(x.MessageBody));
                WriteToFile();
            }
            else
            {
                ViewResultCollection.ToList().ForEach(x =>
                {
                    switch (x.MessageBody)
                    {
                        case "FizzBuzz":
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(x.MessageBody);
                            break;
                        case "Fizz":
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(x.MessageBody);
                            break;
                        case "Buzz":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(x.MessageBody);
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine(x.MessageBody);
                            break;
                    }
                });
                WriteToFile();
            }
        }
        void WriteToFile()
        {
            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
                .CreateSubdirectory("FizzBuzz");

            var text = "";
            ViewResultCollection.ToList().ForEach(x => text = text + x.MessageBody + "\r\n");

            using (StreamWriter sw = new StreamWriter($"{dir}\\StringToFizzBuzz.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
   
}
