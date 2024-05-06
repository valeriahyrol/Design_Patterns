using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Chain
{
    class LevelOne : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Відповідь на рівні 1: Чат підтримки.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Жодного відповідного рівня підтримки не знайдено.");
            }
        }
    }

}
