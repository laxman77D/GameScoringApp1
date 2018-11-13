using System;
using System.Collections.Generic;

namespace GameScoringApp
{
    public class ScoreComponent
    {
        public int CalculateScore(List<string> block, int count)
        {
            int totalScore = 0;
            int currentScore = 0;
            int lastScore = 0;

            if (block.Contains("Z"))
            {
                int index = block.IndexOf("Z");
                block.RemoveAt(index);
                if (index > 1) block.RemoveAt(index - 1);
            }

            for (int j = 0; j < block.Count; j++)
            {
                switch (block[j])
                {
                    case "X":
                        {
                            if (j > 0)
                            {
                                if (int.TryParse(block[j - 1], out int tmpPrevScore))
                                {
                                    currentScore = (2 * tmpPrevScore);
                                    totalScore += currentScore;
                                }

                                lastScore = currentScore;
                            }
                            break;
                        }

                    case "+":
                        {
                            if (j > 0)
                            {
                                totalScore += (currentScore + lastScore);
                                currentScore = (currentScore + lastScore);
                            }
                            break;
                        }

                    default:
                        {
                            totalScore += int.Parse(block[j]);
                            lastScore = int.Parse(block[j]);
                            break;
                        }
                }
            }
            return totalScore;
        }
    }
}
