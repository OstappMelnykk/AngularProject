
using API;
using Microsoft.AspNetCore.Mvc;

namespace Shop.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{

    [HttpGet("GetAllProfiles")]
    public async Task<ActionResult<List<Profile>>> GetAllProfiles()
    {

        var random = new Random();
        int count = random.Next(3, 7); 
        var profiles = Enumerable.Range(1, count)
            .Select(index => GenerateRandomProfile(index))
            .ToList();

        return Ok(profiles);
    }
    
    private Profile GenerateRandomProfile(int id)
    {
        var random = new Random();

        var usernames = new[]
        {
            "user123", "coolCoder", "devGuy", "techGal", "adminPro", "dataWizard", "codeLover", "alphaTester",
            "betaBuilder", "stackMaster", "debugHero", "frontendGuru", "backendKing", "aiEnthusiast", "devOpsPro"
        };

        var firstNames = new[]
        {
            "John", "Jane", "Alex", "Emily", "Chris", "Michael", "Sarah", "David", "Anna", "James",
            "Sophia", "Daniel", "Olivia", "Matthew", "Isabella"
        };

        var lastNames = new[]
        {
            "Smith", "Doe", "Brown", "Johnson", "Williams", "Taylor", "Anderson", "Lee", "Harris", "Clark",
            "Lewis", "Walker", "Hall", "Allen", "Young"
        };

        var cities = new[]
        {
            "New York", "San Francisco", "London", "Berlin", "Kyiv", "Tokyo", "Paris", "Sydney", "Rome", "Chicago",
            "Toronto", "Dublin", "Munich", "Moscow", "Warsaw"
        };

        var descriptions = new[]
        {
            "A highly motivated and passionate developer with extensive experience in creating scalable web applications and cloud-based solutions.",
            "An enthusiastic programmer who enjoys solving complex problems and contributing to innovative projects.",
            "Specializes in full-stack development, combining solid backend skills with an eye for front-end design.",
            "A tech-savvy individual with a deep understanding of modern frameworks and cutting-edge technologies.",
            "Enjoys collaborating with teams to design, implement, and improve software solutions for real-world challenges.",
            "Passionate about artificial intelligence and machine learning, always eager to explore new opportunities in the field.",
            "Experienced in building robust systems and ensuring optimal performance under high-demand scenarios.",
            "A strong advocate for clean code and best practices in software engineering."
        };

        var stacks = new[]
        {
            "C#", "JavaScript", "Python", "Java", "Go", "SQL", "React", "Angular", "Vue.js", "Docker", "Kubernetes",
            "Node.js", "TypeScript", "PHP", "Ruby", "Scala", "Swift", "Objective-C", "Rust", "Perl"
        };

        return new Profile
        {
            Id = id,
            Username = usernames[random.Next(usernames.Length)],
            Description = descriptions[random.Next(descriptions.Length)],
            AvatarUrl = random.Next(0, 2) == 0 ? null : $"https://avatars.com/{Guid.NewGuid()}",
            SubscriptionsAmount = random.Next(0, 1001),
            FirstName = firstNames[random.Next(firstNames.Length)],
            LastName = lastNames[random.Next(lastNames.Length)],
            IsActive = random.Next(0, 2) == 1,
            Stack = Enumerable.Range(1, random.Next(2, 6))
                .Select(_ => stacks[random.Next(stacks.Length)])
                .Distinct()
                .ToArray(),
            City = cities[random.Next(cities.Length)]
        };
    }
    

}