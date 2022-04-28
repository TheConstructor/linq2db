﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LinqToDB;
using LinqToDB.AspNet.Logging;
using LinqToDB.Configuration;
using LinqToDB.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace Tests.Common
{
	[TestFixture]
	public class ConnectionBuilderTests : TestBase
	{
		private class TestLoggerFactory : ILoggerFactory
		{
			public List<TestLogger> Loggers = new ();

			public void Dispose()
			{
			}

			public ILogger CreateLogger(string categoryName)
			{
				var logger = new TestLogger();
				Loggers.Add(logger);
				return logger;
			}

			public void AddProvider(ILoggerProvider provider)
			{
			}
		}

		private class TestLogger : ILogger
		{
			public List<string> Messages = new ();

			public void Log<TState>(LogLevel logLevel,
				EventId eventId,
				TState state,
				Exception? exception,
				Func<TState, Exception?, string> formatter)
			{
				var message = formatter(state, exception);
				Messages.Add(message);
			}

			public bool IsEnabled(LogLevel logLevel)
			{
				return false;
			}

			public IDisposable BeginScope<TState>(TState state) => new Disposable();

			private class Disposable : IDisposable
			{
				void IDisposable.Dispose()
				{
				}
			}
		}

		[Test]
		public void CanUseWithLoggingFromFactory()
		{
			var builder = new DataContextOptionsBuilder();
			var factory = new TestLoggerFactory();
			builder.UseLoggerFactory(factory);

			var extension = builder.Options.GetExtension<CoreOptionsExtension>();

			Assert.NotNull(extension.WriteTrace);

			var expectedMessage = "this is a test log";
			extension.WriteTrace!(expectedMessage, "some category", TraceLevel.Info);

			Assert.That(factory.Loggers, Has.One.Items);
			var testLogger = factory.Loggers.Single();
			Assert.Contains(expectedMessage, testLogger.Messages);
		}

		[Test]
		public void CanUseLoggingFactoryFromIoc()
		{
			var builder  = new DataContextOptionsBuilder();
			var factory  = new TestLoggerFactory();
			var services = new ServiceCollection();
			services.AddSingleton<ILoggerFactory>(factory);
			builder.UseDefaultLogging(services.BuildServiceProvider());

			var extension = builder.Options.GetExtension<CoreOptionsExtension>();
			Assert.NotNull(extension.WriteTrace);

			var expectedMessage = "this is a test log";
			extension.WriteTrace!(expectedMessage, "some category", TraceLevel.Info);

			Assert.That(factory.Loggers, Has.One.Items);
			var testLogger = factory.Loggers.Single();
			Assert.Contains(expectedMessage, testLogger.Messages);
		}
	}
}
