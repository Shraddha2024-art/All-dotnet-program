// using System
// namespace Collection_Demo
// {
//  internal class HashTableDemo

 
//  {
//     static void Main()
//     {
//         // Create a new Hashtable
//         HashTableDemo hashtable = new HashTableDemo();

//         // Add key-value pairs to the Hashtable
//         hashtable.Add("001", "John");
//         hashtable.Add("002", "Jane");
//         hashtable.Add("003", "Joe");

//         // Display the key-value pairs in the Hashtable
//         Console.WriteLine("Hashtable contents:");
//         foreach (DictionaryEntry entry in hashtable)
//         {
//             Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
//         }

//         // Access a value by key
//         string value = (string)hashtable["002"];
//         Console.WriteLine($"\nValue for key '002': {value}");

//         // Remove a key-value pair
//         hashtable.Remove("003");
//         Console.WriteLine("\nHashtable contents after removing key '003':");
//         foreach (DictionaryEntry entry in hashtable)
//         {
//             Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
//         }
//     }

//   }

// }