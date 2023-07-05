using Microsoft.Extensions.FileProviders;
using MudBlazorPlayground.WASM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MudBlazorPlayground.WASM.Services;
public class CountryService
{

    public async Task<List<CountryFlag>> GetCountriesAsync()
    {
        var assembly = Assembly.GetExecutingAssembly();
        string resourcePath = "MudBlazorPlayground.Mobile.Resources.Raw.country-by-flag.json";

        using (Stream stream = assembly.GetManifestResourceStream(resourcePath)!)
        {
            if (stream is null)
            {
                throw new FileNotFoundException();
            }

            return await JsonSerializer.DeserializeAsync<List<CountryFlag>>(stream)!;
        }
    }
}
