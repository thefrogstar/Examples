using System;

namespace LogAPI.Models
{
    public class LogMessage
    {
        public String ID { get; set; }

        public DateTime time { get; set; }

        public String message { get; set; }
    }
}
