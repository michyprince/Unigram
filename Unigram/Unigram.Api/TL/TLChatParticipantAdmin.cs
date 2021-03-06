// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatParticipantAdmin : TLChatParticipantBase 
	{

		public TLChatParticipantAdmin() { }
		public TLChatParticipantAdmin(TLBinaryReader from, TLType type = TLType.ChatParticipantAdmin)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChatParticipantAdmin; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChatParticipantAdmin)
		{
			UserId = from.ReadInt32();
			InviterId = from.ReadInt32();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE2D6E436);
			to.Write(UserId);
			to.Write(InviterId);
			to.Write(Date);
		}
	}
}