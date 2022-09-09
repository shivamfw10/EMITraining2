using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_101_Practice.DataSource;
using Linq_101_Practice;
    

namespace Linq_101_Practice
{
    public class Program 
    {
        static void Main(string[] args)
        {
            AggregateOperators a = new AggregateOperators();
            //a.CountSyntax();
            //a.CountConditional();
            //a.NestedCount();
            //a.GroupedCount();
            //a.SumSyntax();
            //a.SumProjection();
            //a.SumGrouped();
            //a.MinSyntax();
            //a.MinProjection();
            //a.MinGrouped();
            //a.MinEachGroup();
            //a.MaxSyntax();
            //a.MaxProjection();
            //a.MaxGrouped();
            //a.MaxEachGroup();
            //a.AverageSyntax();
            //a.AverageProgection();
            //a.AverageGroup();
            //a.AggregateSyntax();
            //a.SeededAggregate();
            Conversions conversions = new Conversions();
            //conversions.ConvertToArray();
            //conversions.ConvertToList();
            //conversions.ConvertToDictonary();
            //conversions.ConvertSelectedItems();
            ElementOperations eleOperations = new ElementOperations();
            //eleOperations.FirstElement();
            //eleOperations.FirstMatchingElement();
            //eleOperations.MaybeFirstElement();
            //eleOperations.MaybeFirstMatchingElement();
            //eleOperations.ElementAtPosition();
            Generators generators = new Generators();
            //generators.RangeOfInteger();
            //generators.RepeatNumber();
            Grouping grouping = new Grouping();
            //grouping.GroupingSyntax();
            //grouping.GroupByCategory();
            //grouping.NestedGroupBy();
            //grouping.GroupByCustomerComparer();
            //grouping.NestedGroupCustom();
            JoinsOperations joinOperations = new JoinsOperations();
            //joinOperations.OrderBySyntax();
            //joinOperations.OrderByProperty();
            //joinOperations.OrderByProducts();
            //joinOperation.OrderByWithCustomComparer();
            //joinOperations.OrderByDescendingSyntax();
            //joinOperations.OrderProductsDescending();
            //joinOperations.DescendingCustomComparer();
            //joinOperations.ThenBySyntax();
            //joinOperations.ThenByCustom();
            //joinOperations.ThenByDefaultOrdering();
            //joinOperations.CustomThenByDescending();
            //joinOperations.OrderingReversal();
            Partions partions = new Partions();
            //partions.TakeSyntax();
            //partions.NestedTake();
            //partions.SkipSyntax();
            //partions.NestedSkip();
            //partions.TakewhileSyntax();
            //partions.SkipWhileSyntax();
            //partions.IndexedSkipWhile();
            Projections projections = new Projections();
            //projections.SelectSyntax();
            //projections.SelectProperty();
            //projections.TransformWithSelect();
            //projections.SelectByCaseAnonymous();
            //projections.SelectByCaseTuple();
            //projections.SelectAnonymousConstructions();
            //projections.SelectPropertySubset();
            //projections.SelectWithIndex();
            //projections.SelectWithWhere();
            //projections.SelectFromMultipleSequence();
            //projections.SelectFromChildSequence();
            //projections.SelectManyWithWhere();
            //projections.SelectManyWhereAssignment();
            //projections.SelectMultipleWhereClauses();
            //projections.IndexedSelectMany();
            Quantifiers quantifiers = new Quantifiers();
            //quantifiers.AnyMatchingElement();
            //quantifiers.GroupedAnyMatchedElements();
            //quantifiers.AllMatchedElements();
            //quantifiers.GroupedAllMatchedElements();
            QueryExecution queryExecution = new QueryExecution();
            //queryExecution.DeferredExecution();
            //queryExecution.EagerExecution();
            //queryExecution.ReuseQueryDefinition();
            Restrictions restrictions = new Restrictions();
            //restrictions.LowNumbers();
            //restrictions.ProductOutOfStock();
            //restrictions.ExpensiveProductsInStock();
            //restrictions.DisplayCustomerOrders();
            //restrictions.IndexedWhere();
            SequenceOperations sequenceOperations = new SequenceOperations();
            //sequenceOperations.EqualSequence();
            //sequenceOperations.Linq97();
            //sequenceOperations.ConcatSeries();
            //sequenceOperations.ConcatProjections();
            //sequenceOperations.DotProduct();
            SetOperations setOperations = new SetOperations();
            //setOperations.DistinctSyntax();
            //setOperations.DistinctPropertyValues();
            //setOperations.UnionSyntax();
            //setOperations.UnionOfQueryResults();
            //setOperations.IntersectSyntax();
            //setOperations.IntersectQueryResults();
            //setOperations.DifferenceOfSets();
            setOperations.DifferenceOfQueries();

        }
    }
}
