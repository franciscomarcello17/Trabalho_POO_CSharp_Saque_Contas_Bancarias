namespace Exercise155_Exception_Handling.Entities.Exceptions;

class DomainException : ApplicationException
{
    public DomainException(string message) : base(message) 
    {
    }
}