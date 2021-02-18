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
using EdiOverride;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class OverridableEdiProperties
	{
		public static readonly MessageContextProperty<OverrideEDIHeader, bool> Enabled = new();
		public static readonly MessageContextProperty<UNB11, string> UNB11 = new();
		public static readonly MessageContextProperty<UNB2_1, string> UNB2_1 = new();
		public static readonly MessageContextProperty<UNB3_1, string> UNB3_1 = new();
		public static readonly MessageContextProperty<UNB5, string> UNB5 = new();
		public static readonly MessageContextProperty<UNB7, string> UNB7 = new();
		public static readonly MessageContextProperty<UNB9, string> UNB9 = new();
	}
}
