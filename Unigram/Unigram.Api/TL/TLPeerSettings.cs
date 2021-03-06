// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPeerSettings : TLObject 
	{
		[Flags]
		public enum Flag : int
		{
			ReportSpam = (1 << 0),
		}

		public bool IsReportSpam { get { return Flags.HasFlag(Flag.ReportSpam); } set { Flags = value ? (Flags | Flag.ReportSpam) : (Flags & ~Flag.ReportSpam); } }

		public Flag Flags { get; set; }

		public TLPeerSettings() { }
		public TLPeerSettings(TLBinaryReader from, TLType type = TLType.PeerSettings)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PeerSettings; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PeerSettings)
		{
			Flags = (Flag)from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x818426CD);
			to.Write((Int32)Flags);
		}
	}
}