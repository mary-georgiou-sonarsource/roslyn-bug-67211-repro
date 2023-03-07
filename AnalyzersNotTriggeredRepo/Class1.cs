using System;

namespace AnalyzersNotTriggeredRepo
{
    public class Class1
    {
        public class NonSonarWay
        {
            public static void EnabledByRuleset(int a)
            {
                if (a == 1)
                {
                    Console.WriteLine("Cheking...");
                }
                else if (a == 2)
                {
                    Console.WriteLine("Something else");
                }
                else if (a == 3) // S126 should be raised here when enabled by ruleset or .editorconfig
                {
                    Console.WriteLine("S126 should be raised here....");
                }
            }

            public static async void S3168() { } // Raise S3168
        }
    }
}