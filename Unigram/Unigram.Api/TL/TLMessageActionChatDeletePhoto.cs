// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChatDeletePhoto : TLMessageActionBase 
	{
		public TLMessageActionChatDeletePhoto() { }
		public TLMessageActionChatDeletePhoto(TLBinaryReader from, TLType type = TLType.MessageActionChatDeletePhoto)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessageActionChatDeletePhoto; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessageActionChatDeletePhoto)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x95E3FBEF);
		}
	}
}