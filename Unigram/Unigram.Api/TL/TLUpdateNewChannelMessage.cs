// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateNewChannelMessage : TLUpdateBase, ITLMultiPts 
	{

		public TLUpdateNewChannelMessage() { }
		public TLUpdateNewChannelMessage(TLBinaryReader from, TLType type = TLType.UpdateNewChannelMessage)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateNewChannelMessage; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateNewChannelMessage)
		{
			Message = TLFactory.Read<TLMessageBase>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x62BA04D9);
			to.WriteObject(Message);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}