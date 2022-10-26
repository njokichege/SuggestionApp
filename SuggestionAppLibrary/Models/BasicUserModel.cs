

namespace SuggestionAppLibrary.Models;
public class BasicUserModel
{
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string DisplayName { get; set; }


   //allows easy creation of an instance without requiring a UserModel object
   public BasicUserModel()
   {
         
   }
   //take a subset of information from the UserModel that can be used as a refernce by other models eg SuggestionModel
   public BasicUserModel(UserModel user)
   {
      Id= user.Id;   
      DisplayName= user.DisplayName;
   }
}
