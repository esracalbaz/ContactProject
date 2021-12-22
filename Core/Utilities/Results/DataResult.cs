using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>      //Result tan farkı datasının da olması
    {
        public DataResult(T data, bool success, string message):base(success,message)  //Resulttan farkı aynı zamanda data var(Result voidler için)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)     //message göndermek istemezse
        {
            Data = data;
        }
        public T Data { get; }
    }
}
