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
using System.Xml;
using Microsoft.XLANGs.BaseTypes;

// ReSharper disable once CheckNamespace
namespace BTS
{
	[Serializable]
	[PropertyType(nameof(ActualRetryCount), NAMESPACE, "int", "System.Int32")]
	[PropertyGuid(@"95e6968f-1887-40b4-aeaa-8ab36acf28ed")]
	public sealed class ActualRetryCount : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(int);

		#endregion

		internal const string NAMESPACE = "http://schemas.microsoft.com/BizTalk/2003/system-properties";

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(ActualRetryCount), NAMESPACE);
	}

	[Serializable]
	[PropertyType(nameof(ReceiveLocationName), ActualRetryCount.NAMESPACE, "string", "System.String")]
	[PropertyGuid(@"07b9d12b-4f3c-4ea2-b3ae-b7505351a59b")]
	public sealed class ReceiveLocationName : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(string);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(ReceiveLocationName), ActualRetryCount.NAMESPACE);
	}

	[Serializable]
	[PropertyType(nameof(RouteMessageOnFailure), ActualRetryCount.NAMESPACE, "boolean", "System.Boolean")]
	[PropertyGuid(@"ae8c8465-2cd7-444b-b949-b1f639777a8e")]
	public sealed class RouteMessageOnFailure : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(bool);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(RouteMessageOnFailure), ActualRetryCount.NAMESPACE);
	}

	[Serializable]
	[PropertyType(nameof(WasSolicitResponse), ActualRetryCount.NAMESPACE, "boolean", "System.Boolean")]
	[PropertyGuid(@"1b1e28aa-861a-4705-866b-6595ef537e6f")]
	public sealed class WasSolicitResponse : MessageContextPropertyBase
	{
		#region Base Class Member Overrides

		public override XmlQualifiedName Name => _qualifiedName;

		public override Type Type => typeof(bool);

		#endregion

		[NonSerialized]
		private static XmlQualifiedName _qualifiedName = new XmlQualifiedName(nameof(WasSolicitResponse), ActualRetryCount.NAMESPACE);
	}
}
