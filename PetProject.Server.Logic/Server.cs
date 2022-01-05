using PetProject.CommonLogic;
using PetProject.CommonLogic.Metadata;
using PetProject.Server.Data;

namespace PetProject.Server.Logic
{
    public class Server : IServer
    {
        private readonly IDbTypeProvider _typesProvider;
        
        public Server()
        {
            _typesProvider = new MsSqlDbTypesProvider();
        }

        public IDbType CreateType(string typeName, bool isAbstract, Guid guid)
        {
            return _typesProvider.CreateType(typeName, isAbstract, guid);
        }

        public void AddChildType(IDbType parentType, IDbType childType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDbType> GetChildTypes()
        {
            throw new NotImplementedException();
        }

        public void CreateObject(Guid typeGuid)
        {
            throw new NotImplementedException();
        }
    }
}