using PokerResolver;

namespace PokerResolverTests
{
    [TestFixture]
    public class PokerHelperTests
    {
        private static readonly IDictionary<IReadOnlyList<int>, int> EstimatedResults =
            new Dictionary<IReadOnlyList<int>, int>()
            {
                { new [] { 1, 5, 9, 10, 5 }, 12 },
                { new [] { 1, 2, 3 }, 1 },
                { new [] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 2 }, 1 },
            };

        [Test]
        public void TestPokerHelper()
        {
            foreach (var pair in EstimatedResults)
            {
                var result = PokerHelper.GetChipMoves(pair.Key);
                Assert.That(result == pair.Value);
            }
        }
    }
}