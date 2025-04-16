namespace FarmBox.Domain.Shared.Exceptions.Email;

public sealed class InvalidEmailLengthException(string message) : DomainException(message);