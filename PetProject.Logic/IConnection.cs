using PetProject.CommonLogic;

namespace PetProject.Logic;

public interface IConnection
{
    IServer Server { get; }
}