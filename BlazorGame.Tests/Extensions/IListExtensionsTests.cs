using BlazorGame.Extensions;
using System.Collections.Generic;
using Xunit;

namespace BlazorGame.Tests.Extensions
{
    public class IListExtensionsTests
    {
        [Fact]
        public void Shuffle_Should_ChangeListElementOrder()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };

            var shuffledList = new List<int>(list).Shuffle();

            var listsSame = true;
            for (var i = 0; i < list.Count; ++i)
            {
                if (list[i] != shuffledList[i])
                {
                    listsSame = false;
                }
            }

            Assert.False(listsSame);
        }
    }
}
