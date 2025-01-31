using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly AppDbContext _context;

        public ReminderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Reminder> GetByIdAsync(Guid id)
        {
            return await _context.Reminders.FindAsync(id);
        }

        public async Task AddAsync(Reminder reminder)
        {
            await _context.Reminders.AddAsync(reminder);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Reminder reminder)
        {
            _context.Reminders.Update(reminder);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var reminder = await _context.Reminders.FindAsync(id);
            if (reminder != null)
            {
                _context.Reminders.Remove(reminder);
                await _context.SaveChangesAsync();
            }
        }
    }
}