// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageTypingAction : TLSendMessageActionBase 
	{
		public TLSendMessageTypingAction() { }
		public TLSendMessageTypingAction(TLBinaryReader from, TLType type = TLType.SendMessageTypingAction)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.SendMessageTypingAction; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.SendMessageTypingAction)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x16BF744E);
		}
	}
}