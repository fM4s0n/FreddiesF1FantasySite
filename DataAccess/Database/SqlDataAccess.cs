using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Database;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public string ConnectionStringName { get; set; } = "Laptop";

    public SqlDataAccess (IConfiguration config)
    {
        _config = config;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public async Task<List<T>> LoadData<T, Params> (string sql, Params parameters)
    {
        string connectionString = _config.GetConnectionString(ConnectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);
        {
            try
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public async Task SaveData<T> (string sql, T parameters)
    {
        string connectionString = _config.GetConnectionString(ConnectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);
        {
            try
            {
                var name = await connection.ExecuteAsync(sql, parameters);
            }
            catch(Exception ex)
            {
                throw;
            }        
        }
    }
}
