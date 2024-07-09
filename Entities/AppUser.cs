namespace API.Entities;

public class AppUser
{

  //naming conventions mean that 'id' is automatically recognised as the id for the database and, because it is an integer, it will auto-increment 
  public int Id { get; set; }
  public required string UserName { get; set; }
}
