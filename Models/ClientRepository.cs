using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


 public class ClientRepository{

     public string GetJsonText(string path){        
         try{
            var clientObj = File.ReadAllText(path);
            return clientObj;
         }catch(Exception e){
            return "Can't Open The File, Error: "+ e.ToString();
         }
     }
     public Root GetAllDate(){
        return JsonSerializer.Deserialize<Root>(GetJsonText("/home/zegeye/projects/dotNetCore/coreTest/App_Data/Clients.json"));
     }

     public JsonDocument clientsDocument(){
         return JsonDocument.Parse(GetJsonText("/home/zegeye/projects/dotNetCore/coreTest/App_Data/Clients.json"));
     }
 }