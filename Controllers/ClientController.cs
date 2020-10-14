using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase {

    Root client;
    
    public ClientController(ClientRepository clientRepository){
       client = clientRepository.GetAllDate();
    }

    
    [HttpGet]
    public Root Get(){
        
        return client;
    }

}



[ApiController]
[Route("[controller]")]
public class GetClientsController : ControllerBase {

    JsonDocument clientDoc;
   
   public GetClientsController(ClientRepository repo){
       clientDoc = repo.clientsDocument();
   }

    
    [HttpGet]
    public JsonDocument Get(){
        return clientDoc;
    }

}
