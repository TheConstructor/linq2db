﻿using System;
using System.Linq.Expressions;

namespace LinqToDB.Concurrency
{
	using Mapping;

	/// <summary>
	/// Defines optimistic lock column value generation strategy for update.
	/// Used with <see cref="ConcurrencyExtensions" /> extensions.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public abstract class OptimisticLockPropertyBaseAttribute : MappingAttribute
	{
		public OptimisticLockPropertyBaseAttribute()
		{
		}

		/// <summary>
		/// Returns expression for new value for optimistic lock column on successful update.
		/// Should return <c>null</c> if value generated by database.
		/// </summary>
		/// <param name="column">Column descriptor.</param>
		/// <param name="record">Current record variable.</param>
		public abstract LambdaExpression? GetNextValue(ColumnDescriptor column, ParameterExpression record);

		public override string GetObjectID() => $".{Configuration}.";
	}
}