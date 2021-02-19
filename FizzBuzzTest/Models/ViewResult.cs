using FizzBuzzTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Models
{
    public class ViewResult
    {
        public ViewResult(IEnumerable<int> query)
        {
            ViewResultCollection = new List<Message>();

            query.ToList().ForEach(x=>{
                Message check = GetMessage(x);
                if(!(check is null))
                    ViewResultCollection.Add(check);
            });
            
        }

        public ICollection<Message> ViewResultCollection { get; set; }

        Message GetMessage(int number)
        {
            switch (DataAlgorithm.Execute(number))
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
                    return null;
            }
        }
    }
   
}
