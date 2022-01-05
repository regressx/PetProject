using System;

namespace PetProject.Server.Data.Exceptions;

public class CreateTypeException : Exception
{
    public CreateTypeException(string message) : base(message)
    {
    }

    public CreateTypeException(string message, Exception innerException)
    {
    }
}