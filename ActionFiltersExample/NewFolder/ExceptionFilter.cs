using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFiltersExample.NewFolder
{
    public class ExceptionFilter :Attribute,IExceptionFilter
    {
        string Path = @"E:\Logs\log";
      public void OnException(ExceptionContext context)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine(context.Exception.Message);
                sw.WriteLine(context.Exception.StackTrace);

            }

        }
    }
}
