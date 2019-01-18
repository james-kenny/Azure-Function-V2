#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    dynamic body = await req.Content.ReadAsStringAsync();
    var e = JsonConvert.DeserializeObject<Person>(body as string);
 
    return req.CreateResponse(HttpStatusCode.OK, "Ok");
}

public class Person{
    public string firstname {get;set;}
    public string lastname {get;set;}
    public string email {get;set;}
}

