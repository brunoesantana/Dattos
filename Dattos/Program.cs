using System;
using System.Linq;

namespace Dattos
{
    class Program
    {
        private const int LOOP_NUMBER = 7;
        private const int FIRST_POSITION = 0;
        private const int LAST_POSITION = 6;

        static void Main(string[] args)
        {
            var loopController = LOOP_NUMBER;
            var writeLineResult = new char[loopController];
            var firstPositionX = FIRST_POSITION;
            var lastPositionX = LAST_POSITION;
            var isAscending = false;

            for (int i = 0; i < loopController; i++)
            {
                writeLineResult[firstPositionX] = 'x';
                writeLineResult[lastPositionX] = 'x';

                for (int j = 0; j < loopController; j++)
                {
                    if (j == firstPositionX || j == lastPositionX)
                        continue;
                    else
                        writeLineResult[j] = '-';
                }

                writeLineResult.ToList().ForEach(i => Console.Write(i.ToString()));

                Console.WriteLine();

                if(firstPositionX < lastPositionX && !isAscending)
                {
                    firstPositionX += 1;
                    lastPositionX -= 1;
                }
                else
                {
                    firstPositionX -= 1;
                    lastPositionX += 1;
                    isAscending = true;
                }
            }
        }
    }
}
