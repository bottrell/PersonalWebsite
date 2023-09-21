using Microsoft.AspNetCore.Mvc.RazorPages;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using Azure.Identity;

namespace PersonalWebsite.Pages;

public class PostViewModel : PageModel
{
    BlobServiceClient _blobServiceClient;
    string _containerName = "posts";
    public PostViewModel()
    {
        _blobServiceClient = new BlobServiceClient(
            new Uri("https://sajjbblogpostsprod.blob.core.windows.net"),
            new DefaultAzureCredential());
    }
    public string? markdownText { get; set; } = "This is just the default text that comes with the model";

    public async Task<string> Test(int id)
    {
        BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
        BlobClient blobClient = containerClient.GetBlobClient($"{id}.md");
        var reader = await blobClient.OpenReadAsync();
        string contents;
        using (var sr = new StreamReader(reader))
        {
            contents = await sr.ReadToEndAsync();
        }

        Console.WriteLine(contents);
        return contents;
    }
}