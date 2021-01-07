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

namespace Be.Stateless.BizTalk.Namespaces
{
	[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class PropertySchemaNamespaces
	{
		public const string BizTalkFactory = "urn:schemas.stateless.be:biztalk:properties:system:2012:04";
		public const string Edi = "http://schemas.microsoft.com/Edi/PropertySchema";
		public const string System = "http://schemas.microsoft.com/BizTalk/2003/system-properties";
		public const string Wcf = "http://schemas.microsoft.com/BizTalk/2006/01/Adapters/WCF-properties";
	}
}
