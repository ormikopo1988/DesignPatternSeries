﻿using System.Collections.Generic;

namespace Mediator.Solution.UsingObserver
{
    public abstract class UIControl
    {
        private readonly List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler eventHandler)
        {
            eventHandlers.Add(eventHandler);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var eventHandler in eventHandlers)
            {
                eventHandler.Handle();
            }
        }
    }
}
