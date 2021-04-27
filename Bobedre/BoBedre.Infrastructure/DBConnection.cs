using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Infrastructure
{
    public static class DBConnection
    {
        private static readonly string ConnectionString = "Server = den1.mssql8.gear.host; Database = bobedremaegler; User ID = bobedremaegler; Password = Cf4BQaYd!7!D";

        /// <summary>
        /// Executes a non query on the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public static async Task ExecuteNonQuery(SqlCommand sqlCommand)
        {
            SqlConnection Connection = new(ConnectionString);
            sqlCommand.Connection = Connection;
            await Connection.OpenAsync();
            await sqlCommand.ExecuteNonQueryAsync();
            await Connection.CloseAsync();
        }

        /// <summary>
        /// Executes a transation consisting of one or more sql commands
        /// </summary>
        /// <param name="sqlCommands"></param>
        /// <param name="isolationLevel"></param>
        /// <returns></returns>
        public static async Task ExecuteTransaction(List<SqlCommand> sqlCommands, IsolationLevel isolationLevel = IsolationLevel.Snapshot)
        {
            SqlConnection Connection = new(ConnectionString);
            await Connection.OpenAsync();
            SqlTransaction transaction = (SqlTransaction)await Connection.BeginTransactionAsync(isolationLevel);
            try
            {
                foreach (var command in sqlCommands)
                {
                    command.Connection = Connection;
                    command.Transaction = transaction;
                    await command.ExecuteNonQueryAsync();
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            await Connection.CloseAsync();
        }

        /// <summary>
        /// Reads a single element from the database and returns the values of the columns
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public static async Task<object[]> ReadElement(SqlCommand sqlCommand)
        {
            SqlConnection Connection = new(ConnectionString);
            await Connection.OpenAsync();

            object[] values = null;
            sqlCommand.Connection = Connection;

            using (DbDataReader reader = await sqlCommand.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    values = new object[reader.FieldCount];
                    reader.GetValues(values);
                }
            }

            await Connection.CloseAsync();

            return values;
        }

        /// <summary>
        /// Reads multible elements from the database and returns it's values
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public static async Task<List<object[]>> ReadElements(SqlCommand sqlCommand)
        {
            SqlConnection Connection = new(ConnectionString);
            await Connection.OpenAsync();

            var valueList = new List<object[]>();

            using (DbDataReader reader = await sqlCommand.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    valueList.Add(values);
                }
                
            }

            await Connection.CloseAsync();

            return valueList;
        }
    }
}
