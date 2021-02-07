using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;

namespace TaskList.DAL
{
    public class TaskListDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TaskListDbContext(DbContextOptions<TaskListDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}