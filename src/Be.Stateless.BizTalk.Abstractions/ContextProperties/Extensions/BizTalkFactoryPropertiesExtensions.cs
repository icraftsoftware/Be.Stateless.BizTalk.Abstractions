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
using Microsoft.XLANGs.BaseTypes;

namespace Be.Stateless.BizTalk.ContextProperties.Extensions
{
	/// <summary>
	/// Fluent-syntax <see cref="IBaseMessage"/> and <see cref="IBaseMessageContext"/> helpers for <see
	/// cref="BizTalkFactoryProperties"/> context properties.
	/// </summary>
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	public static class BizTalkFactoryPropertiesExtensions
	{
		public static IBaseMessage DisableTransportRetries(this IBaseMessage message)
		{
			message.SetProperty(BtsProperties.RetryCount, 0);
			return message;
		}

		public static IBaseMessageContext DisableTransportRetries(this IBaseMessageContext context)
		{
			context.SetProperty(BtsProperties.RetryCount, 0);
			return context;
		}

		public static IBaseMessage SetMap<T>(this IBaseMessage message) where T : TransformBase
		{
			message.SetProperty(BizTalkFactoryProperties.MapTypeName, typeof(T).AssemblyQualifiedName);
			return message;
		}

		public static IBaseMessageContext SetMap<T>(this IBaseMessageContext context) where T : TransformBase
		{
			context.SetProperty(BizTalkFactoryProperties.MapTypeName, typeof(T).AssemblyQualifiedName);
			return context;
		}

		public static IBaseMessage SetOutboundTransportLocation(this IBaseMessage message, string outboundTransportLocation)
		{
			message.SetProperty(BizTalkFactoryProperties.OutboundTransportLocation, outboundTransportLocation);
			return message;
		}

		public static IBaseMessageContext SetOutboundTransportLocation(this IBaseMessageContext context, string outboundTransportLocation)
		{
			context.SetProperty(BizTalkFactoryProperties.OutboundTransportLocation, outboundTransportLocation);
			return context;
		}
	}
}
