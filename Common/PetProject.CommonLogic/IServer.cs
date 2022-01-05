using PetProject.CommonLogic.Metadata;

namespace PetProject.CommonLogic;

public interface IServer
{
    IDbType CreateType(string typeName, bool isAbstract, Guid guid);

    void AddChildType(IDbType parentType, IDbType childType);

    void CreateObject(Guid typeGuid);
}