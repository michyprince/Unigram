// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesCombined : TLUpdatesBase 
	{
		public Int32 SeqStart { get; set; }

		public TLUpdatesCombined() { }
		public TLUpdatesCombined(TLBinaryReader from, TLType type = TLType.UpdatesCombined)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdatesCombined; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdatesCombined)
		{
			Updates = TLFactory.Read<TLVector<TLUpdateBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Date = from.ReadInt32();
			SeqStart = from.ReadInt32();
			Seq = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x725B04C3);
			to.WriteObject(Updates);
			to.WriteObject(Users);
			to.WriteObject(Chats);
			to.Write(Date);
			to.Write(SeqStart);
			to.Write(Seq);
		}
	}
}