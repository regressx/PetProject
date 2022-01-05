namespace PetProject.CommonLogic;

public interface IDbObject
{
    IDbProperty GetProperty(Guid propertyGuid);

    IDbRelation GetRelation(Guid relatedObject, Guid relationGuid);

    IEnumerable<IDbRelation> GetAllRelations();
}