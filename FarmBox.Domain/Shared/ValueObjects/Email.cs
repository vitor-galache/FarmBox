using System.Text.RegularExpressions;
using FarmBox.Domain.Shared.Exceptions.Email;

namespace FarmBox.Domain.Shared.ValueObjects;

public sealed partial record Email : ValueObject
{
    #region Constants

    private const string Pattern =  @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    public const int MinLength = 3;
    public const int MaxLength = 60;
    #endregion
    
    #region Constructors

    private Email(string address)
    {
        Address = address;
    }

    #endregion
    
    #region Factories

    public static Email Create(string address)
    {
        if (string.IsNullOrWhiteSpace(address) || string.IsNullOrEmpty(address))
            throw new InvalidEmailLengthException("Email address cannot be null or empty.");

        address = address.Trim();
        address = address.ToLower();

        if (!EmailRegex().IsMatch(address))
            throw new InvalidEmailException("Email address is not valid.");

        return new Email(address);
    }

    #endregion
    
    #region Properties

    public string Address { get; }

    #endregion  
    
    public static implicit operator string(Email email) => email.ToString();
    
    #region Overrides

    public override string ToString() => Address;

    #endregion  
    
    #region Source Generators

    [GeneratedRegex(Pattern)]
    private static partial Regex EmailRegex();

    #endregion
}