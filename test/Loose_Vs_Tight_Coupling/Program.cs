using System;

namespace Loose_Vs_Tight_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notification = new Notification(new GPS());

            notification.Notify();
        }

    }

    internal class Email : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }

        /// <inheritdoc />
        public void Play()
        {
            throw new NotImplementedException();
        }
    }

    class MyClass : INotificationMode
    {
        /// <inheritdoc />
        public void Send()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Play()
        {
            throw new NotImplementedException();
        }
    }

    internal class Notification
    {
        private readonly INotificationMode _notificationMode;
        public Notification(INotificationMode mod)
        {
            _notificationMode = mod;
        }
        public void Notify()
        {
            _notificationMode.Send();
        }
    }


    internal interface INotificationMode
    {
        void Send();

        void Play();

    }


    internal class GPS : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("GSP...");
        }

        /// <inheritdoc />
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
