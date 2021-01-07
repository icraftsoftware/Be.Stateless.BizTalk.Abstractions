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
using Microsoft.BizTalk.Message.Interop;

namespace Be.Stateless.BizTalk.Namespaces
{
	[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class ExtensionObjectNamespaces
	{
		/// <summary>
		/// The namespace that any XSLT must declare to <b>automatically</b> benefit from an extension object supporting <see
		/// cref="IBaseMessageContext"/> read, write, and promote operations.
		/// </summary>
		/// <remarks>
		/// If an XSLT choose not to declare this namespace then it is up to itself to instantiate this class and add it as an
		/// extension object.
		/// </remarks>
		public const string MessageContext = "urn:extensions.stateless.be:biztalk:message:context:2012:12";
	}
}
