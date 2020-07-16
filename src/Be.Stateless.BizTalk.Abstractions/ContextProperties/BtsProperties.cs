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
using BTS;

namespace Be.Stateless.BizTalk.ContextProperties
{
	/// <summary>
	/// System properties are mostly used internally by BizTalk Messaging Engine and its components. In general, changing the
	/// values set by the engine for those properties is not recommended, because it may affect the execution logic of the
	/// engine. However, there are a large number of properties that you can change.
	/// </summary>
	/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/master/biztalk/core/how-to-use-message-context-properties.md">How to Use Message Context Properties</seealso>
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class BtsProperties
	{
		public static readonly MessageContextProperty<AckRequired, bool> AckRequired = new();
		public static readonly MessageContextProperty<ActualRetryCount, int> ActualRetryCount = new();
		public static readonly MessageContextProperty<InboundTransportLocation, string> InboundTransportLocation = new();
		public static readonly MessageContextProperty<InboundTransportType, string> InboundTransportType = new();
		public static readonly MessageContextProperty<InterchangeID, string> InterchangeID = new();
		public static readonly MessageContextProperty<IsDynamicSend, bool> IsDynamicSend = new();
		public static readonly MessageContextProperty<IsRequestResponse, bool> IsRequestResponse = new();
		public static readonly MessageContextProperty<IsSolicitResponse, bool> IsSolicitResponse = new();
		public static readonly MessageContextProperty<MessageDestination, string> MessageDestination = new();
		public static readonly MessageContextProperty<MessageID, string> MessageID = new();
		public static readonly MessageContextProperty<MessageType, string> MessageType = new();
		public static readonly MessageContextProperty<Operation, string> Operation = new();

		[SuppressMessage("ReSharper", "IdentifierTypo")]
		[SuppressMessage("ReSharper", "InconsistentNaming")]
		public static readonly MessageContextProperty<OutboundTransportCLSID, string> OutboundTransportCLSID = new();

		public static readonly MessageContextProperty<OutboundTransportLocation, string> OutboundTransportLocation = new();
		public static readonly MessageContextProperty<OutboundTransportType, string> OutboundTransportType = new();
		public static readonly MessageContextProperty<ReceiveLocationName, string> ReceiveLocationName = new();
		public static readonly MessageContextProperty<ReceivePipelineConfig, string> ReceivePipelineConfig = new();
		public static readonly MessageContextProperty<ReceivePortName, string> ReceivePortName = new();
		public static readonly MessageContextProperty<RetryCount, int> RetryCount = new();
		public static readonly MessageContextProperty<RetryInterval, int> RetryInterval = new();
		public static readonly MessageContextProperty<RouteMessageOnFailure, bool> RouteMessageOnFailure = new();
		public static readonly MessageContextProperty<SchemaStrongName, string> SchemaStrongName = new();
		public static readonly MessageContextProperty<SPName, string> SendPortName = new();
		public static readonly MessageContextProperty<SuppressRoutingFailureDiagnosticInfo, bool> SuppressRoutingFailureDiagnosticInfo = new();
		public static readonly MessageContextProperty<SuspendMessageOnRoutingFailure, bool> SuspendMessageOnRoutingFailure = new();
		public static readonly MessageContextProperty<TransmitWorkID, string> TransmitWorkID = new();
		public static readonly MessageContextProperty<WasSolicitResponse, bool> WasSolicitResponse = new();
	}
}
