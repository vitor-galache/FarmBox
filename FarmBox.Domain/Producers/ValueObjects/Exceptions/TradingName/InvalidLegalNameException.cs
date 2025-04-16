using FarmBox.Domain.Shared.Exceptions;

namespace FarmBox.Domain.Producers.ValueObjects.Exceptions.TradingName;

public sealed class InvalidLegalNameException(string message) : DomainException(message);