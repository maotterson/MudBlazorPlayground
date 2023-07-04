using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MudBlazorPlayground.Mobile.Data;
public class CountryFlag
{
    [JsonPropertyName("country")]
    public string Country { get; set; } = default!;
    [JsonPropertyName("flag_base64")]
    public string Flag { get; set; } = default!;
}
