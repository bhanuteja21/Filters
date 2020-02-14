using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFiltersExample.NewFolder
{
    public class ResultFilter: ActionFilterAttribute,IResultFilter
    {
        string Path = @"E:\Logs\log";
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter ss = File.AppendText(Path))
            {
                var sw = (ObjectResult)context.Result;
                ss.WriteLine(sw.Value);
            }
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter ss = File.AppendText(Path))
            {
                var sw = (ObjectResult)context.Result;
                ss.WriteLine(sw.Value);
            }
        }
    }
}
