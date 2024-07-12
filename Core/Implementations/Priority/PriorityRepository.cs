﻿using Core.Interfaces.Priority;
using Core.Models.Priority;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Core.Implementations.Priority
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly TaskManagerDbContext _context;

        public PriorityRepository(TaskManagerDbContext context)
        {
            _context = context;
        }

        public async Task<List<PriorityResponse>> GetPriorities()
        {
            return await _context.Priorities.Select(x => new PriorityResponse()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
        }
    }
}
