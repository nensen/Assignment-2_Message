using System;

namespace Message
{
    internal class Program
    {
        /// <summary>
        /// Output of following program will print custom MessageB and additional MessageB
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IMessage message = new MessageB();

            message.CustomMethod();

            if (message is IAdditionalMessage)
            {
                (message as IAdditionalMessage).AdditionalMethod();
            }

            Console.ReadKey();
        }
    }

    internal class MessageA : IMessage
    {
        public void CustomMethod()
        {
            Console.WriteLine("Custom method of message A");
        }
    }

    internal class MessageB : IMessage, IAdditionalMessage
    {
        public void CustomMethod()
        {
            Console.WriteLine("Custom method of message B");
        }

        public void AdditionalMethod()
        {
            Console.WriteLine("Additional method of message B");
        }
    }

    internal class MessageC : IMessage
    {
        public void CustomMethod()
        {
            Console.WriteLine("Custom method of message C");
        }
    }

    internal interface IMessage
    {
        void CustomMethod();
    }

    internal interface IAdditionalMessage
    {
        void AdditionalMethod();
    }
}