using System;
using System.Collections.Generic;
using PetProject.CommonLogic.Metadata;

namespace PetProject.Server.Data;

public class DatabaseType : IDbType 
{
    public int Id { get; }

    public Guid Guid { get; set; }

    public string Name { get; set; }

    public bool IsAbstract { get; set; }

    public IEnumerable<IDbType> GetChildrenTypes()
    {
        throw new NotImplementedException();
    }
}