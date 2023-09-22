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
    public int Id { get; set; } = 404;
    public string? PostContent { get; set; } = null;
    string _containerName = "posts";

    public PostViewModel()
    {
        _blobServiceClient = new BlobServiceClient(
            new Uri("https://sajjbblogpostsprod.blob.core.windows.net"),
            new DefaultAzureCredential());
    }

    public async Task<string> GetPostContent(int id)
    {
        string contents = "";
        {
            // Get content from online
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
            BlobClient blobClient = containerClient.GetBlobClient($"{id}.md");
            var reader = await blobClient.OpenReadAsync();

            using (var sr = new StreamReader(reader))
            {
                contents = await sr.ReadToEndAsync();
            }

            Console.WriteLine("loading via Blob storage....");

        }
        return contents;
    }

    public async void OnGet(int id)
    {
        Id = id;
        PostContent = await GetPostContent(Id);
    }
}