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
using Microsoft.Adapters.SAP.BiztalkPropertySchema;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "IdentifierTypo")]
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	// Abstract to support syntax extension by inheriting and declaring new static members.
	public abstract class SapProperties
	{
		public static readonly MessageContextProperty<ARCKEY, string> ARCKEY = new();
		public static readonly MessageContextProperty<CIMTYP, string> CIMTYP = new();
		public static readonly MessageContextProperty<CREDAT, string> CREDAT = new();
		public static readonly MessageContextProperty<CRETIM, string> CRETIM = new();
		public static readonly MessageContextProperty<DIRECT, string> DIRECT = new();
		public static readonly MessageContextProperty<DOCNUM, string> DOCNUM = new();
		public static readonly MessageContextProperty<DOCREL, string> DOCREL = new();
		public static readonly MessageContextProperty<DOCTYP, string> DOCTYP = new();
		public static readonly MessageContextProperty<EXPRSS, string> EXPRSS = new();
		public static readonly MessageContextProperty<GUID, string> GUID = new();
		public static readonly MessageContextProperty<IDOC_VERSION, string> IDOC_VERSION = new();
		public static readonly MessageContextProperty<IDOCTYP, string> IDOCTYP = new();
		public static readonly MessageContextProperty<MANDT, string> MANDT = new();
		public static readonly MessageContextProperty<MESCOD, string> MESCOD = new();
		public static readonly MessageContextProperty<MESFCT, string> MESFCT = new();
		public static readonly MessageContextProperty<MESTYP, string> MESTYP = new();
		public static readonly MessageContextProperty<OUTMOD, string> OUTMOD = new();
		public static readonly MessageContextProperty<RCVLAD, string> RCVLAD = new();
		public static readonly MessageContextProperty<RCVPFC, string> RCVPFC = new();
		public static readonly MessageContextProperty<RCVPOR, string> RCVPOR = new();
		public static readonly MessageContextProperty<RCVPRN, string> RCVPRN = new();
		public static readonly MessageContextProperty<RCVPRT, string> RCVPRT = new();
		public static readonly MessageContextProperty<RCVSAD, string> RCVSAD = new();
		public static readonly MessageContextProperty<REFGRP, string> REFGRP = new();
		public static readonly MessageContextProperty<REFINT, string> REFINT = new();
		public static readonly MessageContextProperty<REFMES, string> REFMES = new();
		public static readonly MessageContextProperty<SERIAL, string> SERIAL = new();
		public static readonly MessageContextProperty<SNDLAD, string> SNDLAD = new();
		public static readonly MessageContextProperty<SNDPFC, string> SNDPFC = new();
		public static readonly MessageContextProperty<SNDPOR, string> SNDPOR = new();
		public static readonly MessageContextProperty<SNDPRN, string> SNDPRN = new();
		public static readonly MessageContextProperty<SNDPRT, string> SNDPRT = new();
		public static readonly MessageContextProperty<SNDSAD, string> SNDSAD = new();
		public static readonly MessageContextProperty<STATUS, string> STATUS = new();
		public static readonly MessageContextProperty<STD, string> STD = new();
		public static readonly MessageContextProperty<STDMES, string> STDMES = new();
		public static readonly MessageContextProperty<STDVRS, string> STDVRS = new();
		public static readonly MessageContextProperty<TABNAM, string> TABNAM = new();
		public static readonly MessageContextProperty<TEST, string> TEST = new();
		public static readonly MessageContextProperty<TID, string> TID = new();
	}
}
