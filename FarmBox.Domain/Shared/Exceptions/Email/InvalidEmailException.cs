namespace FarmBox.Domain.Shared.Exceptions.Email;

public class InvalidEmailException(string message) : DomainException(message);