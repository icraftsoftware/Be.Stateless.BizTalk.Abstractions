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
		public static IBaseMessage SetIsDynamicSend(this IBaseMessage message, bool isDynamicSend)
		{
			message.SetProperty(BtsProperties.IsDynamicSend, isDynamicSend);
			return message;
		}

		public static IBaseMessageContext SetIsDynamicSend(this IBaseMessageContext context, bool isDynamicSend)
		{
			context.SetProperty(BtsProperties.IsDynamicSend, isDynamicSend);
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

		public static IBaseMessage SetOutboundTransportLocation(this IBaseMessage message, string outboundTransportLocation)
		{
			message.SetProperty(BtsProperties.OutboundTransportLocation, outboundTransportLocation);
			return message;
		}

		public static IBaseMessageContext SetOutboundTransportLocation(this IBaseMessageContext context, string outboundTransportLocation)
		{
			context.SetProperty(BtsProperties.OutboundTransportLocation, outboundTransportLocation);
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

		public static IBaseMessage SetRetryInterval(this IBaseMessage message, int retryInterval)
		{
			message.SetProperty(BtsProperties.RetryInterval, retryInterval);
			return message;
		}

		public static IBaseMessageContext SetRetryInterval(this IBaseMessageContext context, int retryInterval)
		{
			context.SetProperty(BtsProperties.RetryInterval, retryInterval);
			return context;
		}

		public static IBaseMessage SetRouteMessageOnFailure(this IBaseMessage message, bool routeMessageOnFailure)
		{
			message.SetProperty(BtsProperties.RouteMessageOnFailure, routeMessageOnFailure);
			return message;
		}

		public static IBaseMessageContext SetRouteMessageOnFailure(this IBaseMessageContext context, bool routeMessageOnFailure)
		{
			context.SetProperty(BtsProperties.RouteMessageOnFailure, routeMessageOnFailure);
			return context;
		}

		public static IBaseMessage SetSuppressRoutingFailureDiagnosticInfo(this IBaseMessage message, bool suppressRoutingFailureDiagnosticInfo)
		{
			message.SetProperty(BtsProperties.SuppressRoutingFailureDiagnosticInfo, suppressRoutingFailureDiagnosticInfo);
			return message;
		}

		public static IBaseMessageContext SetSuppressRoutingFailureDiagnosticInfo(this IBaseMessageContext context, bool suppressRoutingFailureDiagnosticInfo)
		{
			context.SetProperty(BtsProperties.SuppressRoutingFailureDiagnosticInfo, suppressRoutingFailureDiagnosticInfo);
			return context;
		}

		public static IBaseMessage SetSuspendMessageOnRoutingFailure(this IBaseMessage message, bool suspendMessageOnRoutingFailure)
		{
			message.SetProperty(BtsProperties.SuspendMessageOnRoutingFailure, suspendMessageOnRoutingFailure);
			return message;
		}

		public static IBaseMessageContext SetSuspendMessageOnRoutingFailure(this IBaseMessageContext context, bool suspendMessageOnRoutingFailure)
		{
			context.SetProperty(BtsProperties.SuspendMessageOnRoutingFailure, suspendMessageOnRoutingFailure);
			return context;
		}
	}
}
