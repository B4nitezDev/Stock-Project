using Domain.Entity;

namespace Application.Dtos.Users
{
    public class CreatedUserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? CustomFields { get; set; }
        public int? Company_Id { get; set; }
        public IEnumerable<UserRole>? UserRoles { get; set; }
    }
}
