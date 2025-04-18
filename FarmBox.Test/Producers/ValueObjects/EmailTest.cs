using FarmBox.Domain.Shared.Exceptions.Email;
using FarmBox.Domain.Shared.ValueObjects;

namespace FarmBox.Test.Producers.ValueObjects;

public class EmailTest
{
    [Theory]
    [InlineData("emailtest@outlook.com")]
    [InlineData("teste@hotmail.com")]
    [InlineData("email@gmail.com")]
    public void ShouldCreateEmailIfAddressIsValid(string address)
    {
        var email = Email.Create(address);
        Assert.Equal(address,email);
    }

    [Theory]
    [InlineData("teste@.com")]
    [InlineData("email-teste")]
    [InlineData("email.com")]
    public void ShouldThrowExceptionIfAddressIsNotValid(string address)
    {
        
        Assert.Throws<InvalidEmailException>(() => Email.Create(address));
    }
    
    [Theory]
    [InlineData(" ")]
    [InlineData("")]
    [InlineData("     ")]
    public void ShouldThrowExceptionIfAddressIsEmptyOrWhiteSpace(string address)
    {
        Assert.Throws<InvalidEmailLengthException>(() => Email.Create(address));
    }
}