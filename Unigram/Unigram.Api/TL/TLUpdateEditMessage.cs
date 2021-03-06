// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEditMessage : TLUpdateBase, ITLMultiPts 
	{

		public TLUpdateEditMessage() { }
		public TLUpdateEditMessage(TLBinaryReader from, TLType type = TLType.UpdateEditMessage)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateEditMessage; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateEditMessage)
		{
			Message = TLFactory.Read<TLMessageBase>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE40370A3);
			to.WriteObject(Message);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}