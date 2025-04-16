using FarmBox.Domain.Producers.ValueObjects.Exceptions.TradingName;
using FarmBox.Domain.Shared.ValueObjects;

namespace FarmBox.Domain.Producers.ValueObjects;

public record TradingName : ValueObject
{
   #region Constants

   public const int MinLength = 3;
   public const int MaxLength = 60;

   #endregion
   
   #region Constructors

   private TradingName(string friendlyName,string legalName)
   {
      FriendlyName = friendlyName;
      LegalName = legalName;
   }
   
   
   #endregion

   #region Factories

   public static TradingName Create(string friendlyName, string legalName)
   {
      if (string.IsNullOrWhiteSpace(legalName))
         throw new InvalidLegalNameException("Legal name cannot be null or empty.");
      
      if(string.IsNullOrWhiteSpace(friendlyName))
         throw new InvalidFriendlyNameException("Friendly name cannot be null or empty.");
      
      return new TradingName(friendlyName, legalName);
   }

   #endregion
   
   #region Properties

   public string FriendlyName { get; } 
   public string LegalName { get;  } 

   #endregion

   #region Implicit and Explicit Operators

   public static implicit operator string(TradingName tradingName) => tradingName.ToString();

   #endregion
   
   #region Overrides

   public override string ToString() => FriendlyName;

   #endregion
}