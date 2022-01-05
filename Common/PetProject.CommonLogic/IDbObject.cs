using PetProject.CommonLogic.Metadata;

namespace PetProject.CommonLogic;

public interface IDbObject
{
    IDbType GetType();

    IDbProperty GetProperty(Guid propertyGuid);

    IDbRelation GetRelation(Guid relatedObject, Guid relationGuid);

    IEnumerable<IDbRelation> GetAllRelations();
}