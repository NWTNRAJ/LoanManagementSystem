using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Company.LoanManagement.Data.Context
{
    public class AppDbContext
    {
        #region Fields
        private static string _connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        #endregion

        #region Methods
        #region Private
        private static SqlConnection OpenConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
        private static SqlCommand CreateCommand(string spName, Dictionary<string, object> parameters)
        {
            var sqlCommand = new SqlCommand()
            {
                Connection = OpenConnection(),
                CommandType = CommandType.StoredProcedure,
                CommandText = spName,
            };
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    var sqlParameters = new SqlParameter(param.Key, param.Value);
                    sqlCommand.Parameters.Add(sqlParameters);
                }
            }
            return sqlCommand;
        }
        #endregion
        #region Public
        public static long Insert(string spName, Dictionary<string, object> parameters)
        {
            using (var sqlCommand = CreateCommand(spName, parameters))
            {
                try
                {
                    sqlCommand.Parameters.Add("@RETURN_VALUE", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue;
                    sqlCommand.ExecuteNonQuery();
                    return Convert.ToInt64(sqlCommand.Parameters["@RETURN_VALUE"].Value);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error insert data. {ex.Message}");
                }
                finally
                {
                    sqlCommand.Connection.Close();
                }
            }
        }
        public static DataTable Select(string spName, Dictionary<string, object> parameters = null)
        {
            using (var sqlCommand = CreateCommand(spName, parameters))
            {
                using (var sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    try
                    {
                        var dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error select data. {ex.Message}");
                    }
                    finally
                    {
                        sqlCommand.Connection.Close();
                    }
                }
            }
        }
        public static long Update(string spName, Dictionary<string, object> parameters)
        {
            using (var sqlCommand = CreateCommand(spName, parameters))
            {
                try
                {
                    return sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error update data. {ex.Message}");
                }
                finally
                {
                    sqlCommand.Connection.Close();
                }
            }
        }
        public static long Delete(string spName, Dictionary<string, object> parameters)
        {
            using (var sqlCommand = CreateCommand(spName, parameters))
            {
                try
                {
                    return sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error delete data. {ex.Message}");
                }
                finally
                {
                    sqlCommand.Connection.Close();
                }
            }
        }
        #endregion
        #endregion
    }
}
