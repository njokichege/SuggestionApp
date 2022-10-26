

namespace SuggestionAppLibrary.Models;
public class UserModel
{
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }//mongodb identifier
   public string ObjectIdentifier { get; set; }//azure identifier
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string DisplayName { get; set; }
   public string EmailAddress { get; set; }
   public List<BasicSuggestionModel> AuthorSuggestions { get; set; } = new();
   public List<BasicSuggestionModel> VotenOnSuggestions { get; set; } = new();

}
