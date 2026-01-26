using IRIS.Domain.Entities;
using IRIS.Infrastructure.Security;

namespace IRIS.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Initialize(IrisDbContext context)
        {
            context.Users.AddRange(
                new User { Username = "officestaff", PasswordHash = PasswordHasher.HashPassword("password"), Role = "OfficeStaff", IsActive = true },
                new User { Username = "assistantdean", PasswordHash = PasswordHasher.HashPassword("password"), Role = "AssistantDean", IsActive = true },
                new User { Username = "dean", PasswordHash = PasswordHasher.HashPassword("password"), Role = "Dean", IsActive = true },
                new User { Username = "qa", PasswordHash = PasswordHasher.HashPassword("password"), Role = "QA", IsActive = true }
            );

            context.SaveChanges();
        }
    }
}
