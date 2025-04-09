using System.Diagnostics.Contracts;

namespace PokerResolver
{
    public static class PokerHelper
    {
        /// <summary>
        /// Returns min moves count to equalize chips in the sleeves
        /// </summary>
        /// <param name="chips">Sleeves' chips count</param>
        /// <returns>Min moves count</returns>
        [Pure]
        public static int GetChipMoves(IReadOnlyList<int> chips)
        {
            var count = chips.Count;
            var total = chips.Sum();

            if (total % count != 0)
            {
                throw new ArgumentException("Can't equalize chips' count");
            }
            
            var targetValue = total / count;

            var differences = new int[count];
            for (var i = 0; i < count; i++)
            {
                differences[i] = chips[i] - targetValue;
            }

            var cumulative = new int[count];
            cumulative[0] = differences[0];
            for (var i = 1; i < count; i++)
            {
                cumulative[i] = cumulative[i - 1] + differences[i];
            }

            Array.Sort(cumulative);
            var median = cumulative[count / 2];

            var moves = 0;
            foreach (var item in cumulative)
            {
                moves += Math.Abs(item - median);
            }

            return moves;
        }
    }
}