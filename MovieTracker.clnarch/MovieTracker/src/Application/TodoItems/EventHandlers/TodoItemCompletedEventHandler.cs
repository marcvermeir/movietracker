﻿using Microsoft.Extensions.Logging;
using MovieTracker.Domain.Events;

namespace MovieTracker.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("MovieTracker Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
