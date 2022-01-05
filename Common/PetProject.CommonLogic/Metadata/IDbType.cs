namespace PetProject.CommonLogic.Metadata;

/// <summary>
/// Информация о типе
/// </summary>
public interface IDbType
{
    int Id { get; }

    Guid Guid { get; set; }

    string Name { get; set; }

    bool IsAbstract { get; set; }

    IEnumerable<IDbType> GetChildrenTypes();
}