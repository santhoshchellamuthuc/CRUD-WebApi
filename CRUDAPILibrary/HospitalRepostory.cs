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

        string connectionstring = string.Empty;
        public HospitalRepostory(IConfiguration configurestion)
        {

            _configurestion = configurestion;
            connectionstring = _configurestion.GetConnectionString("DbConnection");
        }
    }
    public  void Login(HospitalDetails value)
    {
        try
        {
            var insert = $"Insert into HospitalDetails values('{value.Name}','{value.Email}','{value.Address}',{value.Phonenumber},{value.Pincode})";
            connectionstring.open();
            connectionstring.Execute(HospitalDetails);
            connectionstring.close()
        }

    }
}


