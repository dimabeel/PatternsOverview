using System;

namespace TemplateMethod
{
    public abstract class BaseAlgorithm
    {
        protected void PrepareInputData()
        {
            Console.WriteLine("Processing and reading input data...");
        }

        protected virtual void DoOperation1() {}

        protected virtual void DoOperation2() {}

        protected virtual void DoOperation3() {}

        protected void PrepareOutputData()
        {
            Console.WriteLine("Preparing output data...");
        }

        public void ProcessInformation()
        {
            this.PrepareInputData();
            this.DoOperation1();
            this.DoOperation2();
            this.DoOperation3();
            this.PrepareOutputData();
        }
    }
}
