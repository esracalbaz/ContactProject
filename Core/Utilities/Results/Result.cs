using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)  //constructora iki tane parameter verdim
        {
            Message = message;  //set ettim
        }
        public Result(bool success)  //message boş olabilir demektir       //overloading(aşırı yükleme)
        {
            Success = success;
        }
        public bool Success { get; }  //getter demek bir şeyi return et demektir
        public string Message { get; }  //getter--readonly dir,readonlyler constructorda set edilebilir
    }
}
