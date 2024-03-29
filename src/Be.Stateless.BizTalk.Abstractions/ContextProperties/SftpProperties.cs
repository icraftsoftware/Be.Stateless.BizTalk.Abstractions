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

using System.Diagnostics.CodeAnalysis;
using WCF;
using TargetFileName = SFTP.TargetFileName;

namespace Be.Stateless.BizTalk.ContextProperties
{
	/// <summary>
	/// Allow usage of all <see cref="SFTP"/> properties, including <see cref="FolderPath"/>, through the <see cref="WCF"/>
	/// property schema target namespace, which has runtime precedence over the dedicated <see cref="SFTP"/> property schema
	/// target namespace.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Notice that <see cref="FolderPath"/> is not declared by its dedicated <see cref="SFTP"/> property schema and can
	/// therefore only be used through the <see cref="WCF"/> property schema target namespace.
	/// </para>
	/// <para>
	/// It is essential to enable <see cref="BtsProperties.IsDynamicSend"/> when setting the <see cref="FolderPath"/> property
	/// at runtime.
	/// </para>
	/// </remarks>
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class SftpProperties
	{
		/// <summary>
		/// Remote SFTP folder path. Oddly enough, <see cref="FolderPath"/> is concealed in the <see cref="WCF"/> property schema
		/// target namespace only.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The <see cref="FolderPath"/> property is not exposed by the <see cref="SFTP"/> property schema, but at the same time,
		/// any context override of the <see cref="FolderPath"/> value is expected to be found in the <see cref="WCF"/> property
		/// schema target namespace and not in its dedicated <see cref="SFTP"/> property schema target namespace.
		/// </para>
		/// <para>
		/// It is essential to enable <see cref="BtsProperties.IsDynamicSend"/> when setting this property at runtime.
		/// </para>
		/// </remarks>
		public static readonly MessageContextProperty<FolderPath, string> FolderPath = new();

		/// <summary>
		/// Remote SFTP file name.
		/// </summary>
		public static readonly MessageContextProperty<TargetFileName, string> TargetFileName = new();
	}
}
