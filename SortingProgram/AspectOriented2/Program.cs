using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace MEFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer _container = new UnityContainer();
            _container.AddNewExtension<Interception>();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(_container, "containerOne");
            IApplication app = _container.Resolve<Application>();

            string s = app.Run();

            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
    public interface IApplication
    {
        string Run();
    }

    public class Application : IApplication
    {
        public virtual string Run()
        {
            Console.WriteLine("Hello world");
            return "This is my return value";
        }
    }
}