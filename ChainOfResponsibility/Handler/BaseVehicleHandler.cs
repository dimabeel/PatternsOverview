using System;

namespace ChainOfResponsibility
{
    public abstract class BaseVehicleHandler : IHandler
    {
        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        IHandler nextHandler;
    }
}