using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCarro.Dominio
{
    class ModelException:Exception
    {
        public ModelException(string msg) : base(msg) 
        {
        
        }
    }
}
