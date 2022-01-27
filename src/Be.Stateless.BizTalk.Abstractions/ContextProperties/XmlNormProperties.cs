#region Copyright & License

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

using System.Diagnostics.CodeAnalysis;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	public static class XmlNormProperties
	{
		/// <summary>
		/// Whether the XML Assembler pipeline component must preserve or remove the XML declaration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// If this option is set to <c>true</c> the the XML declaration will be added to the document. If the XML declaration
		/// already existed, it will be overwritten.
		/// </para>
		/// <para>
		/// If this option is set to <c>false</c>, no XML declaration will be added and any existing XML declaration will be
		/// removed. The value of this property in the message context takes precedence over the value specified in Pipeline
		/// Designer.
		/// </para>
		/// <para>
		/// It defaults to <c>true</c>; the XML declaration is always added.
		/// </para>
		/// </remarks>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/xml-information-set-elements-in-the-xml-assembler-pipeline-component.md"/>
		public static readonly MessageContextProperty<XMLNORM.AddXMLDeclaration, bool> AddXmlDeclaration = new();

		/// <summary>
		/// Whether the XML Assembler and Disassembler pipeline components allows unrecognized Messages.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It defaults to <c>false</c>.
		/// </para>
		/// </remarks>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/unrecognized-messages-in-the-xml-assembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/unrecognized-messages-in-the-xml-disassembler-pipeline-component.md"/>
		public static readonly MessageContextProperty<XMLNORM.AllowUnrecognizedMessage, bool> AllowUnrecognizedMessage = new();

		public static readonly MessageContextProperty<XMLNORM.BamTrackingOnly, bool> BamTrackingOnly = new();

		public static readonly MessageContextProperty<XMLNORM.DocumentSpecName, string> DocumentSpecName = new();

		public static readonly MessageContextProperty<XMLNORM.EnvelopeSpecName, string> EnvelopeSpecName = new();

		public static readonly MessageContextProperty<XMLNORM.FlatFileHeaderDocument, string> FlatFileHeaderDocument = new();

		/// <summary>
		/// Controls the parsing of the optional flat file instance message header by the flat file disassembler.
		/// </summary>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/flat-file-message-headers.md"/>
		public static readonly MessageContextProperty<XMLNORM.HeaderSpecName, string> HeaderSpecName = new();

		public static readonly MessageContextProperty<XMLNORM.InboundPropertiesTracked, string> InboundPropertiesTracked = new();

		public static readonly MessageContextProperty<XMLNORM.PreserveBom, bool> PreserveBom = new();

		/// <summary>
		/// The processing instructions to add to XML documents.
		/// </summary>
		/// <seealso cref="ProcessingInstructionOption"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/processing-instructions-in-the-xml-assembler-pipeline-component.md"/>
		public static readonly MessageContextProperty<XMLNORM.ProcessingInstruction, string> ProcessingInstruction = new();

		/// <summary>
		/// How to handle the processing instructions specified by <see cref="ProcessingInstruction"/>.
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="ProcessingInstructionOption"/> has three possible values:
		/// <list type="table">
		/// <listheader>
		/// <term>Value</term>
		/// <description>Description</description>
		/// </listheader>
		/// <item>
		/// <term>0</term>
		/// <description>New processing instructions from the XML Assembler are appended to the processing instructions at the beginning of the document.</description>
		/// </item>
		/// <item>
		/// <term>1</term>
		/// <description>New processing instructions from the XML Assembler overwrite existing processing instructions at the beginning of the document.</description>
		/// </item>
		/// <item>
		/// <term>2</term>
		/// <description>Processing instructions at the beginning of the document are removed.</description>
		/// </item>
		/// </list>
		/// </para>
		/// </remarks>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/processing-instructions-in-the-xml-assembler-pipeline-component.md"/>
		public static readonly MessageContextProperty<XMLNORM.ProcessingInstructionOption, int> ProcessingInstructionOption = new();

		public static readonly MessageContextProperty<XMLNORM.ProcessingInstructionScope, int> ProcessingInstructionScope = new();

		/// <summary>
		/// Whether the XML Disassembler pipeline component must disassemble an envelope message into separate body messages.
		/// </summary>
		/// <seealso href="https://programmingatease.wordpress.com/2011/05/03/how-to-skip-debatching-in-xmldisassembler/"/>
		public static readonly MessageContextProperty<XMLNORM.PromotePropertiesOnly, bool> PromotePropertiesOnly = new();

		public static readonly MessageContextProperty<XMLNORM.RecoverableInterchangeProcessing, bool> RecoverableInterchangeProcessing = new();

		/// <summary>
		/// The encoding to use for processing an incoming message.
		/// </summary>
		/// <seealso cref="TargetCharset"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-the-flat-file-disassembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-xml-disassembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-the-xml-assembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-the-flat-file-assembler-pipeline-component.md"/>
		public static readonly MessageContextProperty<XMLNORM.SourceCharset, string> SourceCharset = new();

		/// <summary>
		/// The encoding to use for an outgoing message.
		/// </summary>
		/// <seealso cref="SourceCharset"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-the-xml-assembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/character-encoding-in-the-flat-file-assembler-pipeline-component.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/technical-reference/code-page-node-property-of-flat-file-schemas.md"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/code-page-specification-for-flat-file-schemas.md"/>
		public static readonly MessageContextProperty<XMLNORM.TargetCharset, string> TargetCharset = new();

		/// <summary>
		/// Controls the parsing of the optional flat file instance message trailer by the flat file disassembler.
		/// </summary>
		/// <seealso cref="HeaderSpecName"/>
		/// <seealso cref="HeaderSpecName"/>
		/// <seealso href="https://github.com/MicrosoftDocs/biztalk-docs/blob/main/biztalk/core/flat-file-message-trailers.md"/>
		public static readonly MessageContextProperty<XMLNORM.TrailerSpecName, string> TrailerSpecName = new();
	}
}
