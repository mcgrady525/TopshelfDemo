using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf;

namespace TopshelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.SetServiceName("TopshelfDemo");
                config.SetDisplayName("TopshelfDemo");
                config.SetDescription("TopshelfDemo服务的描述");

                config.Service<MainService>(ser =>
                {
                    ser.ConstructUsing(name => new MainService());
                    ser.WhenStarted((service, control) => service.Start());
                    ser.WhenStopped((service, control) => service.Stop());
                });
            });
        }
    }
}
