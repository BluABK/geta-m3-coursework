using System;

namespace Pure_Puzzles
{
    class MyTask2_9
    {
        /**
         * <summary>
         * Reads a line of text, counting the number of words, identifying:
         *  - The length of the longest word.
         *  - The greatest number of vowels in a word.
         *  - And/Or any other statistics you can think of.
         * </summary>
         */

        string input;
        string[] words;
        public MyTask2_9(string optionalInput = "")
        {
            if (optionalInput == "")
            {
                Console.Write("Input: ");
                input = Console.ReadLine();
            } else
            {
                input = optionalInput;
                Console.WriteLine($"Input: {input}");
            }

            words = input.Split(' ');

            PrintStats();
        }

        private string[] GetLongestWords()
        {
            int longestLength = 0;
            string[] longestWordsMap = new string[words.Length];
            int addedWords = 0;

            for (int i = 0; i < words.Length; i++)
            {
                // If current word is longer than our last stored, and it isn't the same word:
                if (words[i].Length >= longestLength && !Array.Exists(longestWordsMap, e => e == words[i]))
                {
                    // Insert word corresponding to its index.
                    longestWordsMap[i] = words[i];

                    // Update lonst recorded length.
                    longestLength = words[i].Length;

                    // Update added words count.
                    addedWords++;
                }
            }

            // Make new list without the null values and length of added words:
            string[] longestWords = new string[addedWords];

            // Populate the new list:
            //  1. Iterate the longest words map until a non-null value is found.
            //  2. Break inner loop, which increments outer loop.
            //  3. GOTO 1.
            for (int i = 0; i < addedWords; i++)
            {
                // Iterate longst words map until a non-null value is found:
                for (int j = 0; j < longestWordsMap.Length; j++)
                {
                    // Assign current word to a variable for added readability.
                    string word = longestWordsMap[j];

                    // If non-null value is found, and we don't already have it:
                    if (word != null && !Array.Exists(longestWords, e => e == word))
                    {
                        // Insert the word corresponding to the current index at index i in our new list.
                        longestWords[i] = word;

                        // Break out of this inner loop because after a word is added we need to increment i's value.
                        break;
                    }
                }
            }

            return longestWords;
        }
        /**
         * <summary>
         * Determine the longest word(s) and return a gramatically correct formatted string.
         * </summary>
         * 
         * <returns>Gramatically correct sentence string.</returns>
        */
        public string getLongestWordsAsSentence()
        {
            string sentence = "";

            string[] longestWords = GetLongestWords();

            if (longestWords.Length == 0) 
            {
                // If zero words, return NONE
                return "None.";
            } else if (longestWords.Length == 1)
            {
                // If only a single word return word followed by PERIOD.
                return $"{longestWords[0]}.";
            }

            for (int i = 0; i < longestWords.Length; i++)
            {
                sentence += $"\"{longestWords[i]}\"";

                if (i < longestWords.Length - 2)
                {
                    // Add separator if and only if this is not the next to last iteration
                    sentence += ", ";
                } else if (i < longestWords.Length - 1)
                {
                    // Put gramatically correct AND if this is the last iteration.
                    sentence += " and ";
                } else
                {
                    // In the last iteration, end sentence with PERIOD.
                    sentence += ".";
                }
            }

            return sentence;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Longest word(s): {getLongestWordsAsSentence()}");
            Console.WriteLine($"Word count: {words.Length}");
        }
    }
}