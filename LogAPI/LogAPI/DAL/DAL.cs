using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using LogAPI.Models;

namespace LogAPI
{
    public class DAL : IDAL
    {
        private String filename = $"Log {DateTime.Now.ToShortDateString().Replace("/", "-")}.txt";  //Windows does not understand the forward slash


        public void LogMessage(LogMessage message)
        {
            LogMessage(message.ID, message.time, message.message);
        }

        private void LogMessage(string id, DateTime time, string message)
        {
            bool success = false;
            while (!success)
            try
            {
                System.IO.File.WriteAllText(filename, $"{time.ToLocalTime()} : {id} - {message}");
                success = true;
            }
            catch (DirectoryNotFoundException)  
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            catch (Exception)
            {
                //Swallow the error and do something drastic appropriate to the application, write to event log, app insights, send email, flash warning lights or something like that
                success = true;
            }
        }
    }
}
