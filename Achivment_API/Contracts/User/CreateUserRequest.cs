namespace Achivment_API.Contracts.User
{
    public class CreateUserRequest
    {
        public string Nickname { get; set; } = null!;
        public char Email { get; set; }
        public string Country { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Training_goal { get; set; } = null!;
        public string Kind_of_sport { get; set; } = null!;
    }
}
