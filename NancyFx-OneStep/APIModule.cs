using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
namespace NancyFx_OneStep
{
    public class APIModule:NancyModule
    {
        public APIModule()
        {
            Get["api/dynamic"] = p =>
            {
                var model = new { result = true, message = "这是消息" };

                return Response.AsJson(model);
            };

            Get["api/person"] = p =>
            {   
                Person model = new Person() { Name = "科比" };
                return Response.AsJson(model);
            };
        }
    }
    public class Person
    {   
        public string Name { get; set; }
    }
}