using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chainofduties;

namespace Chainofduties
{

    public abstract class Handler 
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract string HandleRequest(string quest);
    }

    public class ConcreteHandler1 : Handler
    {
        public override string HandleRequest(string quest)
        {

            if (quest == "Hi")
            {
                return "Hi, how can i help you?";
            }
            else
            {
                return "";
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override string HandleRequest(string quest)
        {
            if (quest == "Can you help me?")
            {
                return "Yes i can help";
            }
            else
            {
                return "";
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override string HandleRequest(string quest)
        {
            if (quest == "Can you plus numbers?")
            {
                return "Sure i can do it";

            }
            else
            {
                return "";
            }
        }
    }
    public class ConcreteHandler4 : Handler
    {
        public override string HandleRequest(string quest)
        {
            if (quest == "how much will 8 add to 13?")
            {
                return "it will be 21";

            }
            else
            {
                return "Eror";
            }
        }
    }
}
