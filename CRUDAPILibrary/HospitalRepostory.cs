using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDAPILibrary
{
    public class HospitalRepostory
    {
        IConfiguration _configurestion;
        public HospitalRepostory(IConfiguration configurestion)
        {

            _configurestion = configurestion;
            var a = _configurestion.GetConnectionString("DbConnection");

        }
    }
}


