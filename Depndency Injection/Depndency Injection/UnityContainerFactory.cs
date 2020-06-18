//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Practices.Unity;
//using Unity;


//namespace Depndency_Injection
//{
//    class UnityContainerFactory
//    {
//    }
//    public class FactoryMethodUnityExtension<T> : Unity.Extension.UnityContainerExtension
//    {
//        private Func<Type, T> factory;

//        public FactoryMethodUnityExtension(Func<Type, T> factory)
//        {
//            this.factory = factory;
//        }

//        protected override void Initialize()
//        {
//            var strategy = new CustomFactoryBuildStrategy<T>(factory, Context);

//            Context.Strategies.Add(strategy, Unity.Builder.UnityBuildStage.PreCreation);
//        }
//    }

//    public class CustomFactoryBuildStrategy<T> : Unity.Builder.Strategy.BuilderStrategy
//    {
//        private Func<Type, T> factory;
//        private Unity.Extension.ExtensionContext baseContext;
//        private Unity.Extension.ExtensionContext Context;

//        public CustomFactoryBuildStrategy(Func<Type, T> factory, Unity.Extension.ExtensionContext baseContext)
//        {
//            this.factory = factory;
//            this.baseContext = baseContext;
//        }

//        public CustomFactoryBuildStrategy(Func<Type, T> factory, Unity.Extension.ExtensionContext Context)
//        {
//            // TODO: Complete member initialization
//            this.factory = factory;
//            this.Context = Context;
//        }

//        public override void PreBuildUp(Unity.Builder.IBuilderContext context)
//        {
//            var key = (Unity.Builder.NamedTypeBuildKey)context.OriginalBuildKey;

//            if (key.Type.IsInterface && typeof(T).IsAssignableFrom(key.Type))
//            {
//                object existing = baseContext.Locator.Get(key.Type);
//                if (existing == null)
//                {
//                    // create it
//                    context.Existing = factory(key.Type);

//                    // cache it
//                    baseContext.Locator.Add(key.Type, context.Existing);
//                }
//                else
//                {
//                    context.Existing = existing;
//                }
//            }
//        }
//    }
//}
