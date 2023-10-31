using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class MathProblem
    {
        public string Question { get; }
        public int Answer { get; }

        public MathProblem()
        {
            Random random = new Random();
            int num1 = random.Next(1, 10); // Adjust the range as needed
            int num2 = random.Next(1, 10); // Adjust the range as needed
            Question = $"{num1} + {num2} = ?";
            Answer = num1 + num2;
        }
    }

}
