using System.Collections.Generic;

namespace MovingFeatures
{
    class MoveMethod
    {
        public class WordDictionary
        {
            public Dictionary<string, int> HappinessWords { get; set; } = new Dictionary<string, int>();
            public Dictionary<string, int> SaddnessWords { get; set; } = new Dictionary<string, int>();

            public int _happinessScore;
            public int _sadnessScore;

            internal bool HappinessWordsContain(string word)
            {
                return HappinessWords.ContainsKey(word);
            }

            internal bool SadnessWordsContain(string word)
            {
                return SaddnessWords.ContainsKey(word);
            }
        }

        public class WordQuiz
        {
            public List<int> CalculateWordScore(WordDictionary wordDictionary, List<string> happiness, List<string> sadness)
            {
                CalculateHappiness(wordDictionary, happiness);

                CalculateSadness(wordDictionary, sadness);

                PreparePageForOutput();

                return new List<int> { wordDictionary._happinessScore, wordDictionary._sadnessScore };
            }

            private void CalculateSadness(WordDictionary wordDictionary, List<string> sadness)
            {
                wordDictionary._sadnessScore = 0;
                //Move method
                for (int i = 0; i < sadness.Count; i++)
                {
                    if (wordDictionary.SadnessWordsContain(sadness[i]))
                    {
                        int val;
                        wordDictionary.SaddnessWords.TryGetValue(sadness[i], out val);
                        wordDictionary._sadnessScore += val;
                    }
                }
            }

            private void CalculateHappiness(WordDictionary wordDictionary, List<string> happiness)
            {
                wordDictionary._happinessScore = 0;
                //Move method
                for (int i = 0; i < happiness.Count; i++)
                {
                    if (wordDictionary.HappinessWordsContain(happiness[i]))
                    {
                        int val;
                        wordDictionary.HappinessWords.TryGetValue(happiness[i], out val);
                        wordDictionary._happinessScore += val;
                    }
                }
            }

            #region Other methods

            private void PreparePageForOutput()
            {
                //some UI rendering code
            }

            #endregion
        }
    }
}
