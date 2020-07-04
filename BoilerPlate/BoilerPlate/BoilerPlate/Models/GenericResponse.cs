using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerPlates.Models
{
    public class GenericResponse<T>
    {
        long Code { get; set; } 
        public string Message { get; set; }
        public bool IsError { get; set; }
        public T Result { get; set; }
    }
}
