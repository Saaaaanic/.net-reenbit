using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Components.Forms;

namespace ReenbitTest.Data;

public class User
{
    [EmailAddress]
    public string? Email { get; set; }
    public IBrowserFile File { get; set; }
}