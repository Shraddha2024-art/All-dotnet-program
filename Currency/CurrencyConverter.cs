namespace Currency;

public class CurrencyConverter

{



    public decimal ConvertINDtoUSD(decimal amount)
    {
        return amount/85.00m;

    }


    public decimal ConvertUSDtoIND(decimal amount)
    {
        return amount*85.00m;
    }

}
