using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace EmailFunction;

[StorageAccount("BlobConnectionString")]
public static class SendEmail
{
    [FunctionName("SendEmail")]
    public static async Task RunAsync([BlobTrigger("files/{name}")] Stream myBlob,
        string name, IDictionary<string, string> metaData, ILogger log)
    {
        log.LogInformation($"C# Blob trigger function processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        
        string subject = "New file uploaded: " + name;
        string body = "The file " + name + " has been successfully uploaded";
        
        var client = new SendGridClient(Environment.GetEnvironmentVariable("SendGridString"));
        var msg = new SendGridMessage()
        {
            From = new EmailAddress("finadensan@gmail.com"),
            Subject = subject,
            PlainTextContent = body,
            HtmlContent = body
        };
        msg.AddTo(new EmailAddress(metaData["Email"]));

        var response = client.SendEmailAsync(msg).Result;
        log.LogInformation(response.StatusCode.ToString());
    }
}