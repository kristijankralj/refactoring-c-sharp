using System.Collections.Generic;

namespace MovingFeatures
{
    class MoveField
    {
        public class WordDictionary
        {
            public Dictionary<string, int> HappinessWords { get; set; } = new Dictionary<string, int>();
            public Dictionary<string, int> SaddnessWords { get; set; } = new Dictionary<string, int>();

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
            private int _happinessScore;
            private int _sadnessScore;

            public List<int> CalculateWordScore(WordDictionary wordDictionary, List<string> happiness, List<string> sadness)
            {
                _happinessScore = 0;
                //Move method
                for (int i = 0; i < happiness.Count; i++)
                {
                    if (wordDictionary.HappinessWordsContain(happiness[i]))
                    {
                        int val;
                        wordDictionary.HappinessWords.TryGetValue(happiness[i], out val);
                        _happinessScore += val;
                    }
                }

                _sadnessScore = 0;
                //Move method
                for (int i = 0; i < sadness.Count; i++)
                {
                    if (wordDictionary.SadnessWordsContain(sadness[i]))
                    {
                        int val;
                        wordDictionary.SaddnessWords.TryGetValue(sadness[i], out val);
                        _sadnessScore += val;
                    }
                }

                PreparePageForOutput();

                return new List<int> { _happinessScore, _sadnessScore };
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
