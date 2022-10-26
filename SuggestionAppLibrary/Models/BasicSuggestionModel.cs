

namespace SuggestionAppLibrary.Models;
public class BasicSuggestionModel
{
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string Suggestion { get; set; }


   //allows easy creation of an instance without requiring a SuggestionModel object
   public BasicSuggestionModel() 
   {

   }

   //take a subset of information from the SuggestionModel that can be used as a refernce by other models eg UserModel
   public BasicSuggestionModel(SuggestionModel suggestion)
   {
      Id = suggestion.Id;
      Suggestion = suggestion.Suggestion;
   }
}
