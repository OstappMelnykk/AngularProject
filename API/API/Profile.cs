namespace API;

public class Profile
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Description { get; set; }
    public string? AvatarUrl { get; set; }
    public int SubscriptionsAmount { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    public string[] Stack { get; set; }
    public string City { get; set; }
}