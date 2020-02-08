using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Tests.Helpers.TheoryData.Base
{
    internal abstract class CardsValidatorTheoryDataBase<T> : IEnumerable<object[]>
    {
        T validator;

        protected CardsValidatorTheoryDataBase(T validator)
        {
            this.validator = validator;
        }

        protected abstract IList<List<object>> GetTheoryData();

        public IEnumerator<object[]> GetEnumerator() =>
            this.GetTheoryData()
                .Select(list =>
                {
                    list.Insert(0, this.validator);
                    return list.ToArray();
                })
             .GetEnumerator();
        

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}