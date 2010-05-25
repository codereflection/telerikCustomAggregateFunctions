using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Data;

namespace CustomAggregateFunctionSL
{
    public class MyAggregateSelectorFunction : EnumerableSelectorAggregateFunction
    {

        protected override string AggregateMethodName
        {
            get { return "CountDistinct"; }
        }

        protected override Type ExtensionMethodsType
        {
            get
            {
                return typeof(MyAggregates);
            }
        }
    }

    public static class MyAggregates
    {

        public static int CountDistinct<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (!source.Any<TSource>())
            {
                return 0;
            }

            var result = source.Select(selector).Distinct().Count();

            return result;
        }


        public static int CountDistinct<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (!source.Any<TSource>())
            {
                return 0;
            }

            var result = source.Select(selector).Distinct().Count();

            return result;
        }

        public static int CountDistinct<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (!source.Any<TSource>())
            {
                return 0;
            }

            var result = source.Select(selector).Distinct().Count();

            return result;
        }

    }
}
