using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int Number { get; set; }
        public string MessageBody { get; set; }
        public DateTime LastChangedOn { get; set; } = DateTime.UtcNow;
    }
}
