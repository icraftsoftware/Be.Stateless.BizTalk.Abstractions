#region Copyright & License

// Copyright © 2012 - 2021 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Diagnostics.CodeAnalysis;
using Be.Stateless.BizTalk.Message.Extensions;
using Microsoft.BizTalk.Message.Interop;

namespace Be.Stateless.BizTalk.ContextProperties.Extensions
{
	/// <summary>
	/// Fluent-syntax <see cref="IBaseMessage"/> and <see cref="IBaseMessageContext"/> helpers for <see cref="BtsProperties"/>
	/// context properties.
	/// </summary>
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	public static class BtsPropertiesExtensions
	{
		public static IBaseMessage EnableDynamicSend(this IBaseMessage message)
		{
			message.SetProperty(BtsProperties.IsDynamicSend, true);
			return message;
		}

		public static IBaseMessageContext EnableDynamicSend(this IBaseMessageContext context)
		{
			context.SetProperty(BtsProperties.IsDynamicSend, true);
			return context;
		}

		public static IBaseMessage SetOperation(this IBaseMessage message, string operation)
		{
			message.SetProperty(BtsProperties.Operation, operation);
			return message;
		}

		public static IBaseMessageContext SetOperation(this IBaseMessageContext context, string operation)
		{
			context.SetProperty(BtsProperties.Operation, operation);
			return context;
		}

		public static IBaseMessage SetRetryCount(this IBaseMessage message, int retryCount)
		{
			message.SetProperty(BtsProperties.RetryCount, retryCount);
			return message;
		}

		public static IBaseMessageContext SetRetryCount(this IBaseMessageContext context, int retryCount)
		{
			context.SetProperty(BtsProperties.RetryCount, retryCount);
			return context;
		}

		public static IBaseMessage SetRetryInterval(this IBaseMessage message, TimeSpan interval)
		{
			message.SetProperty(BtsProperties.RetryInterval, (int) interval.TotalMinutes);
			return message;
		}

		public static IBaseMessageContext SetRetryInterval(this IBaseMessageContext context, TimeSpan interval)
		{
			context.SetProperty(BtsProperties.RetryInterval, (int) interval.TotalMinutes);
			return context;
		}

		public static IBaseMessage RouteMessageOnFailure(this IBaseMessage message)
		{
			message.SetProperty(BtsProperties.RouteMessageOnFailure, true);
			return message;
		}

		public static IBaseMessageContext RouteMessageOnFailure(this IBaseMessageContext context)
		{
			context.SetProperty(BtsProperties.RouteMessageOnFailure, true);
			return context;
		}

		public static IBaseMessage SuppressRoutingFailureDiagnosticInfo(this IBaseMessage message)
		{
			message.SetProperty(BtsProperties.SuppressRoutingFailureDiagnosticInfo, true);
			return message;
		}

		public static IBaseMessageContext SuppressRoutingFailureDiagnosticInfo(this IBaseMessageContext context)
		{
			context.SetProperty(BtsProperties.SuppressRoutingFailureDiagnosticInfo, true);
			return context;
		}

		public static IBaseMessage SuspendMessageOnRoutingFailure(this IBaseMessage message)
		{
			message.SetProperty(BtsProperties.SuspendMessageOnRoutingFailure, true);
			return message;
		}

		public static IBaseMessageContext SuspendMessageOnRoutingFailure(this IBaseMessageContext context)
		{
			context.SetProperty(BtsProperties.SuspendMessageOnRoutingFailure, true);
			return context;
		}
	}
}
