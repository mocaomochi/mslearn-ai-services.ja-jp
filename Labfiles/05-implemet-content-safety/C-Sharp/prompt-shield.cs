//
// Copyright (c) Microsoft. All rights reserved.
// To learn more, please visit the documentation - Quickstart: Azure Content Safety: https://aka.ms/acsstudiodoc
//

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

/// <summary>
/// Class representing a text prompt injection request.
/// </summary>
public class ShieldPromptRequest
{
    /// <summary>
    /// User prompt to be analyzed.
    /// </summary>
    public string UserPrompt { get; set; }

    /// <summary>
    /// Documents to be analyzed.
    /// </summary>
    public string[] Documents { get; set; }

    /// <summary>
    /// Constructor for the ShieldPromptRequest class.
    /// </summary>
    /// <param name="userPrompt">The user prompt to be analyzed.</param>
    /// <param name="documents">The documents to be analyzed.</param>
    public ShieldPromptRequest(string userPrompt, string[] documents)
    {
        UserPrompt = userPrompt ?? throw new ArgumentNullException(nameof(userPrompt));
        Documents = documents ?? throw new ArgumentNullException(nameof(documents));
        if (documents.Length == 0)
        {
            throw new ArgumentException("At least one document must be provided.", nameof(documents));
        }
    }
}

public class Program
{
    private static readonly HttpClient Client = new HttpClient();

    static async Task Main(string[] args)
    {
        // Replace with your own subscription_key and endpoint
        string subscriptionKey = "<subscription_key>";
        string endpoint = "<endpoint>";

        // Set the userPrompt and documents to be analyzed
        string userPrompt = "<test_content>";
        string[] documents = {
                "<This_is_a_document_source>",
                "<this_is_another_document_source>"
        };

        // Set up the API request
        string url = $"{endpoint}/contentsafety/text:shieldPrompt?api-version=2024-09-01";
        Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

        var shieldPrompt = new ShieldPromptRequest(userPrompt, documents);

        string payload = JsonSerializer.Serialize(shieldPrompt, shieldPrompt.GetType());

        using var content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");

        try
        {
            HttpResponseMessage response = await Client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Analysis result: " + result);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP request exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
