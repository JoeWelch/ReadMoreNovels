using System;
using System.Text.Json.Serialization;

namespace BookApi;

public class GlobalEnv
{
    static GlobalEnv()
    {
        API_VERSION = "0.1.0";
        GOOGLE_API_KEY = Environment.GetEnvironmentVariable("ENV_GOOGLE_API_KEY"); // Database host name
        GOOGLE_URL = Environment.GetEnvironmentVariable("ENV_GOOGLE_URL"); // Database host name

        jsonOptions = new System.Text.Json.JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
        };
        jsonOptions.Converters.Add(new JsonStringEnumConverter());
    }

    public static readonly string GOOGLE_API_KEY;
    public static readonly string GOOGLE_URL;

    public static readonly string API_VERSION;

    public static readonly System.Text.Json.JsonSerializerOptions jsonOptions;

}
