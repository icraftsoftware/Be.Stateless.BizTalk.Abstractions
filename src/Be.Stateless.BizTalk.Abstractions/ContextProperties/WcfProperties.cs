#region Copyright & License

// Copyright © 2012 - 2022 François Chabot
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
using WCF;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class WcfProperties
	{
		public static readonly MessageContextProperty<Action, string> Action = new();
		public static readonly MessageContextProperty<CustomBrokeredPropertyNamespace, string> CustomBrokeredPropertyNamespace = new();
		public static readonly MessageContextProperty<Headers, string> Headers = new();
		public static readonly MessageContextProperty<HttpHeaders, string> HttpHeaders = new();
		public static readonly MessageContextProperty<HttpMethodAndUrl, string> HttpMethodAndUrl = new();
		public static readonly MessageContextProperty<Identity, string> Identity = new();
		public static readonly MessageContextProperty<InboundBodyLocation, string> InboundBodyLocation = new();
		public static readonly MessageContextProperty<InboundBodyPathExpression, string> InboundBodyPathExpression = new();
		public static readonly MessageContextProperty<MaxConcurrentCalls, int> MaxConcurrentCalls = new();
		public static readonly MessageContextProperty<MaxConnections, int> MaxConnections = new();
		public static readonly MessageContextProperty<OutboundBodyLocation, string> OutboundBodyLocation = new();
		public static readonly MessageContextProperty<OutboundXmlTemplate, string> OutboundXmlTemplate = new();
		public static readonly MessageContextProperty<SendTimeout, string> SendTimeout = new();
		public static readonly MessageContextProperty<SuppressMessageBodyForHttpVerbs, string> SuppressMessageBodyForHttpVerbs = new();
		public static readonly MessageContextProperty<TimeToLive, string> TimeToLive = new();
		public static readonly MessageContextProperty<To, string> To = new();
		public static readonly MessageContextProperty<VariablePropertyMapping, string> VariablePropertyMapping = new();
	}
}
