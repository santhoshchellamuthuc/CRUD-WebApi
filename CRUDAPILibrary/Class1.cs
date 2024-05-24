
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dapper;
    using System.Data.SqlClient;
    using SanthoshLibrary;
    using System;
    using System.Collections.Generic;

    namespace santcon

    {
        public class RegistrsationRepostry
        {
            string connectionString = "Data source=DESKTOP-23V7KHU;Initial Catalog=SanthoshkumarChellamuthu;User id=sa;password=Anaiyaan@123;";
            SqlConnection objj;
            public RegistrsationRepostry()
            {
                objj = new SqlConnection(connectionString);
            }
            public void Signup(Registrasation obj)
            {
                try
                {

                    var insetSql = $"Insert into Registrasation Values('{obj.UserName}', '{obj.UserId}','{obj.Email}',{obj.PhoneNumber})";
                    //  objj = new SqlConnection(connectionString);
                    objj.Open();
                    objj.Execute(insetSql);
                    objj.Close();
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



            public void Update(long b, string a)
            {
                try
                {

                    var updateSql = $"Update  Registrasation set PhoneNumber={b} where UserName='{a}'; ";

                    objj.Open();
                    objj.Execute(updateSql);
                    objj.Close();
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
            public void Delete(string NewUserName)
            {
                try
                {
                    var DeleteSql = $"Delete from Registrasation Where UserName='{NewUserName}' ";
                    objj.Open();
                    objj.Execute(DeleteSql);
                    objj.Close();
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
            public IEnumerable<Registrasation> Selectall()
            {
                try
                {
                    var SelectQuery = $"Select UserName,UserId,Email,PhoneNumber from Registrasation";
                    objj.Open();
                    var result = objj.Query<Registrasation>(SelectQuery);
                    objj.Close();
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
            public IEnumerable<Registrasation> Searchall(string name)
            {
                try
                {
                    var searchQuery = $"Select UserName,UserId,Email,PhoneNumber from Registrasation where UserName like '%{name}%'";
                    objj.Open();
                    var matching = objj.Query<Registrasation>(searchQuery);
                    objj.Close();
                    return matching;
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
            /// <summary>
            /// /////////////////////////////////////////////////////////////////////////////////////storeprocedure///////////////////////////////////
            /// </summary>
            /// <param name="store"></param>
            public void storeprocedureSignup(Registrasation store)
            {
                try
                {
                    var InsertSql = ($"EXEC SaveRegistrasation'{store.UserName}','{store.UserId}','{store.Email}','{store.PhoneNumber}'");
                    objj.Open();
                    objj.Execute(InsertSql);
                    objj.Close();

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

            public void SPupdate(string a, long b)
            {
                try
                {

                    var SPupdateSql = $"exec SPupdate'{a}',{b} ";
                    objj.Open();
                    objj.Execute(SPupdateSql);
                    objj.Close();
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
            public void SPdelete(string s)
            {
                try
                {
                    var SPdelete = $"exec SPdelete'{s}'";
                    objj.Open();
                    objj.Execute(SPdelete);
                    objj.Close();

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
            public IEnumerable<Registrasation> SPselectall()
            {
                try
                {
                    var selectQuery = $"select UserName,UserId,Email,PhoneNumber from Registrasation";
                    objj.Open();
                    var Result = objj.Query<Registrasation>(selectQuery);
                    objj.Close();
                    return Result;
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

            /// <summary>
            /// validate ////
            /// </summary>
            /// <param name="UserName"></param>
            /// <returns></returns>
            public IEnumerable<Registrasation> SPvaildate(string UserName)
            {
                try
                {
                    var checker = $"exec SPvaildate'{UserName}'";
                    objj.Open();
                    var checking = objj.Query<Registrasation>(checker);
                    objj.Close();
                    return checking;
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
            public IEnumerable<Registrasation> SPsearchall(string sa)
            {
                try
                {
                    var SearchQuery = $"exec SPsearchall {sa} ";
                    objj.Open();
                    var Searchall = objj.Query<Registrasation>(SearchQuery);
                    objj.Close();
                    return Searchall;
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


