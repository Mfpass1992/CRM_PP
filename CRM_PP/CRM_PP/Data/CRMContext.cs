using Microsoft.EntityFrameworkCore;
using CRM_PP.Models;

namespace CRM_PP.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options) 
        {    
        }
        
        public DbSet<User> User { get; set; }
    }
}
