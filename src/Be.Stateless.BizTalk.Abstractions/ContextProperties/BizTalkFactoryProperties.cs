#region Copyright & License

// Copyright © 2012 - 2020 François Chabot
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
using Be.Stateless.BizTalk.Schemas.BizTalkFactory;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class BizTalkFactoryProperties
	{
		public static readonly MessageContextProperty<ContextBuilderTypeName, string> ContextBuilderTypeName
			= new MessageContextProperty<ContextBuilderTypeName, string>();

		public static readonly MessageContextProperty<MapTypeName, string> MapTypeName
			= new MessageContextProperty<MapTypeName, string>();

		public static readonly MessageContextProperty<MessageBodyStreamFactoryTypeName, string> MessageBodyStreamFactoryTypeName
			= new MessageContextProperty<MessageBodyStreamFactoryTypeName, string>();

		public static readonly MessageContextProperty<MessageType, string> MessageType
			= new MessageContextProperty<MessageType, string>();

		public static readonly MessageContextProperty<OutboundTransportLocation, string> OutboundTransportLocation
			= new MessageContextProperty<OutboundTransportLocation, string>();

		public static readonly MessageContextProperty<XmlTranslations, string> XmlTranslations
			= new MessageContextProperty<XmlTranslations, string>();
	}
}
