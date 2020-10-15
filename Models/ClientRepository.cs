using System;
using System.IO;
using System.Text.Json;


/// <summary>
/// Main repository class
/// Contains  methods for performing json reading from a file
/// and deserialization to POCO.
/// </summary>
 public class ClientRepository{

    /// <summary>
    /// Reads the contents of a JSON file from a given path
    /// </summary>
    /// <returns>
    /// A stringified version of a JSON document
    /// </returns>
    /// <exception cref="System.IO">Thrown when there is IO error on reading the file
    /// which includes file not found exception.</exception>
    /// <param name="path">A double precision number.</param>
    private string GetJsonText(string path){        
         try{
            var clientObj = File.ReadAllText(path);
            return clientObj;
         }catch(Exception e){
            return "Can't Open The File, Error: "+ e.ToString();
         }
    }
    /// <summary>
    /// Deserialize a give JSON string to a type Root
    /// </summary>
    /// <returns>
    /// A Root object which holds a list of clients
    /// </returns>
     public Root GetAllDate(){
        return JsonSerializer.Deserialize<Root>(GetJsonText("/home/zegeye/projects/dotNetCore/coreTest/App_Data/Clients.json"));
     }

    /// <summary>
    /// Directly parses the JSON string returned from GetJsonText
    /// </summary>
    /// <returns>
    /// A JSON document having the clients
    /// </returns>
     public JsonDocument ClientsDocument(){
         return JsonDocument.Parse(GetJsonText("/home/zegeye/projects/dotNetCore/coreTest/App_Data/Clients.json"));
     }
 }