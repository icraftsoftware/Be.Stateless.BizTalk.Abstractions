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

using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using Microsoft.XLANGs.BaseTypes;

// ReSharper disable once CheckNamespace
namespace EDI
{
	[Serializable]
	[PropertyType(nameof(BGM1_1), NAMESPACE, "string", "")]
	[PropertyGuid(@"2a0ba9ec-e3ed-44b8-a590-344e904f89ac")]
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public sealed class BGM1_1 : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		internal const string NAMESPACE = "http://schemas.microsoft.com/Edi/PropertySchema";

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(BGM1_1), NAMESPACE);
	}

	[Serializable]
	[PropertyType(nameof(MKS1), BGM1_1.NAMESPACE, "string", "System.String")]
	[PropertyGuid(@"7386286c-ae36-49ab-b688-f66a57e33dbf")]
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public sealed class MKS1 : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(MKS1), BGM1_1.NAMESPACE);
	}
}
