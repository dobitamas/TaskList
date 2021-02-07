using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using TaskList.Domain;

namespace TaskList.DAL
{
    public partial class TaskListDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TaskListDbContext(DbContextOptions<TaskListDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}