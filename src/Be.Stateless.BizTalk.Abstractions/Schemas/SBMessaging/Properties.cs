﻿#region Copyright & License

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

using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using Be.Stateless.BizTalk.Namespaces;
using Microsoft.XLANGs.BaseTypes;

// ReSharper disable once CheckNamespace
namespace WCF
{
	[Serializable]
	[PropertyType(nameof(CustomBrokeredPropertyNamespace), PropertySchemaNamespaces.Wcf, "string", "System.String")]
	[PropertyGuid(@"cdb5347e-bf04-4c24-9873-139edbe9b14e")]
	public sealed class CustomBrokeredPropertyNamespace : MessageContextPropertyBase
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local", Justification = "To be able to use the property in an XLANG/s expressions.")]
		private static string PropertyValueType => throw new NotSupportedException();

		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new(nameof(CustomBrokeredPropertyNamespace), PropertySchemaNamespaces.Wcf);
	}
}
