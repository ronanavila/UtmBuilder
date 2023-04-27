namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidCampignException : Exception
{
    private const string DefaultErrorMessage = "Invalid Utm parameters";
    public InvalidCampignException(string message = DefaultErrorMessage) : base(message)
    {
    }

    internal static void ThrowIfNull(string parameter, string message = DefaultErrorMessage)
    {
      if (string.IsNullOrEmpty(parameter))
            throw new InvalidCampignException(message);
    }
}
