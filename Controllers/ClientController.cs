using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

/// <summary>
/// Returns a list of Clients
/// </summary>
/// <returns>A list of client document</returns>
[ApiController]
[Route("[controller]")]
public class clientsController : ControllerBase {

    Root clients;
    
    public clientsController(ClientRepository clientRepository){
        clients = clientRepository.GetAllDate();
    }
    
    [HttpGet]
    public Root Get(){
        
        return clients;
    }

}


/// <summary>
/// Returns a list of Clients
/// </summary>
/// <returns>A list of client document</returns>
[ApiController]
[Route("v2/[controller]")]
public class clientDocumentsController : ControllerBase {

    JsonDocument clients;
   
   public clientDocumentsController(ClientRepository clientRepository){
       clients = clientRepository.ClientsDocument();
   }

    [HttpGet]
    public JsonDocument Get(){
        return clients;
    }

}
