// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMessagesFilterDocument : TLMessagesFilterBase 
	{
		public TLInputMessagesFilterDocument() { }
		public TLInputMessagesFilterDocument(TLBinaryReader from, TLType type = TLType.InputMessagesFilterDocument)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterDocument; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputMessagesFilterDocument)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9EDDF188);
		}
	}
}