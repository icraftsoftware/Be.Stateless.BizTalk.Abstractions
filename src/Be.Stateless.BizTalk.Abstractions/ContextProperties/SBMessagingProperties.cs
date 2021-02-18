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
using SBMessaging;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class SBMessagingProperties
	{
		public static readonly MessageContextProperty<ContentType, string> ContentType = new();
		public static readonly MessageContextProperty<CorrelationId, string> CorrelationId = new();
		public static readonly MessageContextProperty<CustomBrokeredMessagePropertyNamespace, string> CustomBrokeredMessagePropertyNamespace = new();
		public static readonly MessageContextProperty<DeliveryCount, int> DeliveryCount = new();
		public static readonly MessageContextProperty<EnqueuedTimeUtc, DateTime> EnqueuedTimeUtc = new();
		public static readonly MessageContextProperty<ExpiresAtUtc, DateTime> ExpiresAtUtc = new();
		public static readonly MessageContextProperty<Label, string> Label = new();
		public static readonly MessageContextProperty<LockedUntilUtc, DateTime> LockedUntilUtc = new();
		public static readonly MessageContextProperty<LockToken, string> LockToken = new();
		public static readonly MessageContextProperty<MessageId, string> MessageId = new();
		public static readonly MessageContextProperty<ReplyTo, string> ReplyTo = new();
		public static readonly MessageContextProperty<ReplyToSessionId, string> ReplyToSessionId = new();
		public static readonly MessageContextProperty<ScheduledEnqueueTimeUtc, DateTime> ScheduledEnqueueTimeUtc = new();
		public static readonly MessageContextProperty<SequenceNumber, string> SequenceNumber = new();
		public static readonly MessageContextProperty<SessionId, string> SessionId = new();
		public static readonly MessageContextProperty<TimeToLive, string> TimeToLive = new();
		public static readonly MessageContextProperty<To, string> To = new();
	}
}
