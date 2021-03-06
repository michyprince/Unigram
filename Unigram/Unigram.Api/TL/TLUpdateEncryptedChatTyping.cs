// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEncryptedChatTyping : TLUpdateBase 
	{

		public TLUpdateEncryptedChatTyping() { }
		public TLUpdateEncryptedChatTyping(TLBinaryReader from, TLType type = TLType.UpdateEncryptedChatTyping)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateEncryptedChatTyping; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateEncryptedChatTyping)
		{
			ChatId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1710F156);
			to.Write(ChatId);
		}
	}
}