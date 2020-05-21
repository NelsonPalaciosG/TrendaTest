using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendaTest.Web.Data.Entities
{
    public class Log
    {
        public int Id { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string Response { get; set; }

        public string Request { get; set; }
    }
}
