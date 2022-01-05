using System;
using System.Data;
using System.Data.SqlClient;
using PetProject.CommonLogic.Metadata;
using PetProject.Server.Data.Exceptions;

namespace PetProject.Server.Data;

public class MsSqlDbTypesProvider : IDbTypeProvider
{
    public IDbType CreateType(string name, bool isAbstract, Guid guid)
    {
        DatabaseType dbType = new()
        {
            Name = name,
            IsAbstract = isAbstract
        };

        string connectionString = @"Data Source=.\REGRESSPC;Initial Catalog=PetProjectDb;Integrated Security=True";
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            IDbCommand command = new SqlCommand();

            command.CommandText = $"INSERT dbo.Types (Guid, Name, IsAbstract) VALUES ('{guid}', '{dbType.Name}', '{isAbstract}')";
            command.Connection = connection;

            if (command.ExecuteNonQuery() != 1)
                throw new CreateTypeException($"Не удалось создать новый тип {name}");
        }

        return dbType;
    }
}