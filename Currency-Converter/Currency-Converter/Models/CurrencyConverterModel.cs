using System.ComponentModel.DataAnnotations;

public class CurrencyConverterModel
{
    [Required(ErrorMessage = "Please enter the amount")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive number")]
    public double Amount { get; set; }

    [Required(ErrorMessage = "Please select the currency from")]
    public string FromCurrency { get; set; }

    [Required(ErrorMessage = "Please select the currency to")]
    public string ToCurrency { get; set; }
}