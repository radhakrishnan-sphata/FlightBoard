using System;

namespace FlightBoard.Core.Utilities
{
    public class ServiceFactory<T>
    {
        private static T instance = Activator.CreateInstance<T>();

        public static T Instance
        {
            get
            {
                return ServiceFactory<T>.instance;
            }
            set
            {
                ServiceFactory<T>.instance = value;
            }
        }

        private ServiceFactory()
        {
        }
    }
}