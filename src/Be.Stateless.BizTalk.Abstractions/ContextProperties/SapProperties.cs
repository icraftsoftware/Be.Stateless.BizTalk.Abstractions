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
		public static readonly MessageContextProperty<ARCKEY, string> ARCKEY
			= new MessageContextProperty<ARCKEY, string>();

		public static readonly MessageContextProperty<CIMTYP, string> CIMTYP
			= new MessageContextProperty<CIMTYP, string>();

		public static readonly MessageContextProperty<CREDAT, string> CREDAT
			= new MessageContextProperty<CREDAT, string>();

		public static readonly MessageContextProperty<CRETIM, string> CRETIM
			= new MessageContextProperty<CRETIM, string>();

		public static readonly MessageContextProperty<DIRECT, string> DIRECT
			= new MessageContextProperty<DIRECT, string>();

		public static readonly MessageContextProperty<DOCNUM, string> DOCNUM
			= new MessageContextProperty<DOCNUM, string>();

		public static readonly MessageContextProperty<DOCREL, string> DOCREL
			= new MessageContextProperty<DOCREL, string>();

		public static readonly MessageContextProperty<DOCTYP, string> DOCTYP
			= new MessageContextProperty<DOCTYP, string>();

		public static readonly MessageContextProperty<EXPRSS, string> EXPRSS
			= new MessageContextProperty<EXPRSS, string>();

		[SuppressMessage("Naming", "CA1720:Identifier contains type name")]
		public static readonly MessageContextProperty<GUID, string> GUID
			= new MessageContextProperty<GUID, string>();

		[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores")]
		public static readonly MessageContextProperty<IDOC_VERSION, string> IDOC_VERSION
			= new MessageContextProperty<IDOC_VERSION, string>();

		public static readonly MessageContextProperty<IDOCTYP, string> IDOCTYP
			= new MessageContextProperty<IDOCTYP, string>();

		public static readonly MessageContextProperty<MANDT, string> MANDT
			= new MessageContextProperty<MANDT, string>();

		public static readonly MessageContextProperty<MESCOD, string> MESCOD
			= new MessageContextProperty<MESCOD, string>();

		public static readonly MessageContextProperty<MESFCT, string> MESFCT
			= new MessageContextProperty<MESFCT, string>();

		public static readonly MessageContextProperty<MESTYP, string> MESTYP
			= new MessageContextProperty<MESTYP, string>();

		public static readonly MessageContextProperty<OUTMOD, string> OUTMOD
			= new MessageContextProperty<OUTMOD, string>();

		public static readonly MessageContextProperty<RCVLAD, string> RCVLAD
			= new MessageContextProperty<RCVLAD, string>();

		public static readonly MessageContextProperty<RCVPFC, string> RCVPFC
			= new MessageContextProperty<RCVPFC, string>();

		public static readonly MessageContextProperty<RCVPOR, string> RCVPOR
			= new MessageContextProperty<RCVPOR, string>();

		public static readonly MessageContextProperty<RCVPRN, string> RCVPRN
			= new MessageContextProperty<RCVPRN, string>();

		public static readonly MessageContextProperty<RCVPRT, string> RCVPRT
			= new MessageContextProperty<RCVPRT, string>();

		public static readonly MessageContextProperty<RCVSAD, string> RCVSAD
			= new MessageContextProperty<RCVSAD, string>();

		public static readonly MessageContextProperty<REFGRP, string> REFGRP
			= new MessageContextProperty<REFGRP, string>();

		public static readonly MessageContextProperty<REFINT, string> REFINT
			= new MessageContextProperty<REFINT, string>();

		public static readonly MessageContextProperty<REFMES, string> REFMES
			= new MessageContextProperty<REFMES, string>();

		public static readonly MessageContextProperty<SERIAL, string> SERIAL
			= new MessageContextProperty<SERIAL, string>();

		public static readonly MessageContextProperty<SNDLAD, string> SNDLAD
			= new MessageContextProperty<SNDLAD, string>();

		public static readonly MessageContextProperty<SNDPFC, string> SNDPFC
			= new MessageContextProperty<SNDPFC, string>();

		public static readonly MessageContextProperty<SNDPOR, string> SNDPOR
			= new MessageContextProperty<SNDPOR, string>();

		public static readonly MessageContextProperty<SNDPRN, string> SNDPRN
			= new MessageContextProperty<SNDPRN, string>();

		public static readonly MessageContextProperty<SNDPRT, string> SNDPRT
			= new MessageContextProperty<SNDPRT, string>();

		public static readonly MessageContextProperty<SNDSAD, string> SNDSAD
			= new MessageContextProperty<SNDSAD, string>();

		public static readonly MessageContextProperty<STATUS, string> STATUS
			= new MessageContextProperty<STATUS, string>();

		public static readonly MessageContextProperty<STD, string> STD
			= new MessageContextProperty<STD, string>();

		public static readonly MessageContextProperty<STDMES, string> STDMES
			= new MessageContextProperty<STDMES, string>();

		public static readonly MessageContextProperty<STDVRS, string> STDVRS
			= new MessageContextProperty<STDVRS, string>();

		public static readonly MessageContextProperty<TABNAM, string> TABNAM
			= new MessageContextProperty<TABNAM, string>();

		public static readonly MessageContextProperty<TEST, string> TEST
			= new MessageContextProperty<TEST, string>();

		public static readonly MessageContextProperty<TID, string> TID
			= new MessageContextProperty<TID, string>();
	}
}
