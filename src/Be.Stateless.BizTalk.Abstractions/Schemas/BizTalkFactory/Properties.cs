﻿#region Copyright & License

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
using System.Xml;
using Be.Stateless.BizTalk.Namespaces;
using Microsoft.XLANGs.BaseTypes;

namespace Be.Stateless.BizTalk.Schemas.BizTalkFactory
{
	[Serializable]
	[PropertyType(nameof(ContextBuilderTypeName), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"5f13dc2c-c8eb-4dff-aee0-c30ccde19a7c")]
	public sealed class ContextBuilderTypeName : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static readonly XmlQualifiedName _qualifiedName = new(nameof(ContextBuilderTypeName), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(DisableTransportRetries), PropertySchemaNamespaces.System, "boolean", "System.Boolean")]
	[PropertyGuid(@"f6531afc-a129-4314-a811-3325b112ee5b")]
	public sealed class DisableTransportRetries : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(bool);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(DisableTransportRetries), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(MapTypeName), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"522f0b3a-be08-458f-bd06-8bc28319a947")]
	public sealed class MapTypeName : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(MapTypeName), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(MessageBodyStreamFactoryTypeName), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"7fec7d64-15ba-4f4d-ad95-33a380783197")]
	public sealed class MessageBodyStreamFactoryTypeName : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(MessageBodyStreamFactoryTypeName), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(MessageType), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"e1c7ba1b-5e2a-4f15-81a2-8842dc31103a")]
	public sealed class MessageType : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(MessageType), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(OutboundTransportLocation), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"4c488b95-0750-4853-8ec0-299d25043992")]
	public sealed class OutboundTransportLocation : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(OutboundTransportLocation), PropertySchemaNamespaces.BizTalkFactory);
	}

	[Serializable]
	[PropertyType(nameof(XmlTranslations), PropertySchemaNamespaces.BizTalkFactory, "string", "System.String")]
	[PropertyGuid(@"53631fc8-c92a-459a-847a-99aef62d7cd4")]
	public sealed class XmlTranslations : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(XmlTranslations), PropertySchemaNamespaces.BizTalkFactory);
	}
}
