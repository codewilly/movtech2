using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts
{
    public class Response<T>
    {
        public T Content { get; set; } 

        public List<string> Errors { get; set; }
    }
}
