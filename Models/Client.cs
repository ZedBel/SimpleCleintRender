using System;

/// <summary>
/// A Base class for a client domain representation
/// </summary>
 public class Client    {
        public string id { get; set; } 
        public int age { get; set; } 
        public string name { get; set; } 
        public string gender { get; set; }
        public AdditionalInfo additionalInfo {get; set;}
    }