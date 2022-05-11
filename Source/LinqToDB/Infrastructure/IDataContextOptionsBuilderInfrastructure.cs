﻿using System;

namespace LinqToDB.Infrastructure
{
	/// <summary>
	/// <para>
	/// Explicitly implemented by <see cref="DataContextOptionsBuilder" /> to hide methods that are used by database provider
	/// extension methods but not intended to be called by application developers.
	/// </para>
	/// <para>
	/// This interface is typically used by database providers (and other extensions). It is generally
	/// not used in application code.
	/// </para>
	/// </summary>
	public interface IDataContextOptionsBuilderInfrastructure
	{
		/// <summary>
		/// <para>
		/// Adds the given extension to the options. If an existing extension of the same type already exists, it will be replaced.
		/// </para>
		/// <para>
		/// This property is intended for use by extension methods to configure the context. It is not intended to be used in
		/// application code.
		/// </para>
		/// </summary>
		/// <typeparam name="TExtension"> The type of extension to be added. </typeparam>
		/// <param name="extension"> The extension to be added. </param>
		void AddOrUpdateExtension<TExtension>(TExtension extension)
			where TExtension : class, IDataContextOptionsExtension;
	}
}