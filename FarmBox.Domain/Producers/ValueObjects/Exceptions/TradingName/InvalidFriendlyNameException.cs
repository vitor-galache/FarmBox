using FarmBox.Domain.Shared.Exceptions;

namespace FarmBox.Domain.Producers.ValueObjects.Exceptions.TradingName;

public sealed class InvalidFriendlyNameException(string message) : DomainException(message);