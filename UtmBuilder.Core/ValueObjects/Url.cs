using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Adress of URL</param>
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }

    /// <summary>
    /// URL Address
    /// </summary>
    public string Address { get; }

}
