using CodeSniffs.API.Data;
using CodeSniffs.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;

namespace CodeSniffs.API.Services
{
    public class UsersService
    {
        private readonly DbHelper _dbHelper;
        private readonly CodesniffsDbContext _context;

        public UsersService(DbHelper dbHelper, CodesniffsDbContext context)
        {
            _dbHelper = dbHelper;
            _context = context;
        }

      
    }
}
