using System;

public class Word
{
        private static System.Random random;

        public Word()
        {
            random = new System.Random();
        }

        public static int GenerateRandomNumber()
        {
            return random.Next(2, 6);
        }

    // public 

        // Scripture scripture = new Scripture();
        // string scriptureWords = scripture.getScripture();


    // // public string scri = "Adam fell";
    // // string[] substrings = scri.Split(" ");



    // Some stuff that was originally in Program:
    
            // string[] subscripture = scriptureWords.Split(new[] {' '});
        

            // for (int i = 0; i <subscripture.Length; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         subscripture[i] = new string('_', subscripture[i].Length);
            //         // subscripture[i] = "_";
            //     }
            // }
            // string hideDisplay = string.Join(" ", subscripture);
            // Console.WriteLine(hideDisplay);
}