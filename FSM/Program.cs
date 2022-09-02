
using System.Diagnostics;
using System.Linq.Expressions;

namespace FSM
{
    enum state { development, examination, agreement, statement, canceled, storage };
    public class Masine
    {
        state actualState;


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            state key = 0;
            switch (key)
            {
                case state.development:
                    break;
                case state.examination:
                    break;
                case state.agreement:
                    break;
                case state.statement:
                    break;
                case state.canceled:
                    break;
                case state.storage:
                    break;
                default:
                    break;
            }

        }
    }
}