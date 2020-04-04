namespace NancyExample.Hosting.Self
{
    using System.Linq;
    using Nancy;
    using NancyExample.Hosting.Self.Models;

    public class ExampleModule : NancyModule
    {
        public ExampleModule()
        {
            Get("/wellcome/{name}", args =>
            {
                return $"Wellcome, {args.name}";
            });

            Get("/measjson/{name}", args =>
            {
                return Negotiate
                    .WithModel(new Person { Name = args.name });
            });

            Get("/", args =>
            {
                return View["staticview", this.Request.Url];
            });

        }
    }
}