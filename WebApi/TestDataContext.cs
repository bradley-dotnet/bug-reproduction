namespace WebApi
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class TestDataContext : IdentityDbContext<IdentityUser>
    {
        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        {
        }
    }
}