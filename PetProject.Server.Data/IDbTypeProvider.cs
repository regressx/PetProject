using System;
using PetProject.CommonLogic.Metadata;

namespace PetProject.Server.Data;

public interface IDbTypeProvider
{
    IDbType CreateType(string name, bool isAbstract, Guid guid);
}