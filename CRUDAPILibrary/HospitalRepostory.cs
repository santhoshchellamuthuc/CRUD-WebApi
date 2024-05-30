using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DapperData;
using Dapper;
using System.Threading.Tasks;





namespace CRUDAPILibrary
{
    public class HospitalRepostory
    {
        string connectionstring = "Data source=DESKTOP-23V7KHU;Initial Catalog=SanthoshkumarAPI;User id=sa;password=Anaiyaan@123";
        SqlConnection refer;
        public HospitalRepostory()
        {
            refer = new SqlConnection(connectionstring);

        }
        public void HospitalLogin(HospitalDetails value)
        {
            try
            {
                var insert = ($"EXEC HospitalLogin '{value.Name}','{value.Email}','{value.Address}',{value.Phonenumber},{value.Pincode}");
                refer.Open();
                refer.Execute(insert);
                refer.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public IEnumerable<HospitalDetails> Hospitalshow()
        {
            try
            {
                var insert = ($"select *from HospitalDetails");
                refer.Open();
                var result = refer.Query<HospitalDetails>(insert);
                refer.Close();
                return result;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<HospitalDetails> Hospitalsearch(string name)
        {
            try
            {
                var insert = $"EXEC HospitalSearch '{name}'";
                refer.Open();
                var result = refer.Query<HospitalDetails>(insert);
                refer.Close();
                return result;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void HospitalEdit(long Id,string data)
        {
            try
            {
                var refer = $"EXEC HospitalEdit {Id},'{data}'";
            }catch(SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void HospitalRemove(int id)
        {
            try
            {
                var value = $"exec HospitalDelete {id}";
                refer.Open();
                refer.Execute(value);
                refer.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
   
}


