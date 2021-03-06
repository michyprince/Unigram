// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMsgResendReq : TLObject 
	{
		public TLVector<Int64> MsgIds { get; set; }

		public TLMsgResendReq() { }
		public TLMsgResendReq(TLBinaryReader from, TLType type = TLType.MsgResendReq)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MsgResendReq; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MsgResendReq)
		{
			MsgIds = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7D861A08);
			to.WriteObject(MsgIds);
		}
	}
}