using System;
using Akka.DI.AutoFac;
using Akka.DI.Core;
using Autofac;

// ReSharper disable once CheckNamespace
namespace Akka.Actor
{
    /// <summary>
    /// Extension methods for <see cref="ActorSystem"/> to configure Autofac
    /// </summary>
    public static class ActorSystemExtensions
    {
        /// <summary>
        /// Creates a new instance of the <see cref="AutoFacDependencyResolver"/> class
        /// associated with the <see cref="ActorSystem"/>
        /// </summary>
        /// <param name="system">The actor system to plug into</param>
        /// <param name="container">The container used to resolve references</param>
        /// <exception cref="ArgumentNullException">
        /// If the <paramref name="container"/> parameter is null.
        /// </exception>
        public static ActorSystem UseAutofac(this ActorSystem system, ILifetimeScope container)
        {
            UseAutofac(system, container, out _);
            return system;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AutoFacDependencyResolver"/> class
        /// associated with the <see cref="ActorSystem"/>
        /// </summary>
        /// <param name="system">The actor system to plug into</param>
        /// <param name="container">The container used to resolve references</param>
        /// <param name="dependencyResolver">The Autofac dependency resolver instance created</param>
        /// <exception cref="ArgumentNullException">
        /// If the <paramref name="container"/> parameter is null.
        /// </exception>
        public static ActorSystem UseAutofac(this ActorSystem system, ILifetimeScope container, out IDependencyResolver dependencyResolver)
        {
            if (container == null) throw new ArgumentNullException(nameof(container));

            dependencyResolver = new AutoFacDependencyResolver(container, system);
            return system;
        }
    }
}
