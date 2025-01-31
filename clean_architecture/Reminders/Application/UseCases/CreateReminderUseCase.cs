using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class CreateReminderUseCase
    {
        private readonly IReminderRepository _repository;

        public CreateReminderUseCase(IReminderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Reminder> Execute(string title, string description)
        {
            var reminder = new Reminder
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description
            };

            await _repository.AddAsync(reminder);
            return reminder;
        }
    }
}