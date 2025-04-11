using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MDCTRevised
{
    public class ExceptionLister
    {
        public ExceptionLister()
        {
            
        }

        /// <summary>
        /// Returns a list of all possible exceptions that can occur.
        /// </summary>
        /// <returns>An Exception list with all available exceptions.</returns>
        public Exception[] ListExceptions()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var exceptionTypes = assemblies
                .SelectMany(a =>
                {
                    try
                    {
                        return a.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        return ex.Types.Where(t => t != null);
                    }
                })
                .Where(t => t != null
                         && typeof(Exception).IsAssignableFrom(t)
                         && !t.IsAbstract)
                .Distinct()
                .ToArray();

            // Attempt to create instances
            var exceptionInstances = exceptionTypes
                .Select(t =>
                {
                    try
                    {
                        // Prefer parameterless constructor
                        var ctor = t.GetConstructor(Type.EmptyTypes);
                        if (ctor != null)
                        {
                            return Activator.CreateInstance(t) as Exception;
                        }
                    }
                    catch
                    {
                        // Ignore types that fail to instantiate
                    }
                    return null;
                })
                .Where(e => e != null)
                .ToArray();


            return exceptionInstances;
        }
    }
}
