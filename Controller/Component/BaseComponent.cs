using System;

namespace Controller
{
    public abstract class BaseComponent
    {
        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        protected IController controller;
    }
}
