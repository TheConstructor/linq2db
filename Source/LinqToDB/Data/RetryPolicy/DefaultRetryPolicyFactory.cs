﻿using System;

namespace LinqToDB.Data.RetryPolicy
{
	using DataProvider.SqlServer;

	static class DefaultRetryPolicyFactory
	{
		public static IRetryPolicy? GetRetryPolicy(DataConnection dataContext)
		{
			if (dataContext.DataProvider is SqlServerDataProvider)
			{
				var retryOptions = dataContext.Options.Find<RetryPolicyOptions>() ?? Common.Configuration.RetryPolicy.Options;

				return new SqlServerRetryPolicy(retryOptions.MaxRetryCount, retryOptions.MaxDelay,
					retryOptions.RandomFactor, retryOptions.ExponentialBase, retryOptions.Coefficient, null);
			}

			return null;
		}
	}
}
