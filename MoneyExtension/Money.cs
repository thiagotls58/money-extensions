namespace MoneyExtension;
public static class Money
{
    public static int ToCent(this decimal amount)
    {
        if (amount <= 0) 
            return 0;

        var text = amount.ToString("N2")
            .Replace(",", "")
            .Replace(".", "");
        
        if (string.IsNullOrEmpty(text)) 
            return 0;

        int.TryParse(text, out int result);
        return result;
    }
}
