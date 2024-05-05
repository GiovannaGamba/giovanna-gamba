using Newtonsoft.Json.Converters;

namespace AGP.MultiSearch.API.Utils;

public class CustomDateFormatConverter : IsoDateTimeConverter
{
    public CustomDateFormatConverter()
    {
        DateTimeFormat = "dd/MM/yyyy";
    }
}
