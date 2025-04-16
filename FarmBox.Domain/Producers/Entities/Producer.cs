using FarmBox.Domain.Producers.ValueObjects;
using FarmBox.Domain.Shared.Entities;
using FarmBox.Domain.Shared.ValueObjects;

namespace FarmBox.Domain.Producers.Entities;

public sealed class Producer : Entity
{
    #region Constructors

    private Producer(string friendlyName, string legalName,string email) : base(Guid.NewGuid())
    {
        Name = TradingName.Create(friendlyName, legalName);
        Email = Email.Create(email);
        
    }

    #endregion

    #region Factories

    #endregion

    #region Properties

    public TradingName Name { get; }

    public Email Email { get; private set; }

    // public string Password { get; private set; }

    public Address Address { get; private set; }

    #endregion

    #region Overrides

    #endregion
}