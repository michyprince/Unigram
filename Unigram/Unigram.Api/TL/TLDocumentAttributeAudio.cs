// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeAudio : TLDocumentAttributeBase 
	{
		[Flags]
		public enum Flag : int
		{
			Voice = (1 << 10),
			Title = (1 << 0),
			Performer = (1 << 1),
			Waveform = (1 << 2),
		}

		public bool IsVoice { get { return Flags.HasFlag(Flag.Voice); } set { Flags = value ? (Flags | Flag.Voice) : (Flags & ~Flag.Voice); } }
		public bool HasTitle { get { return Flags.HasFlag(Flag.Title); } set { Flags = value ? (Flags | Flag.Title) : (Flags & ~Flag.Title); } }
		public bool HasPerformer { get { return Flags.HasFlag(Flag.Performer); } set { Flags = value ? (Flags | Flag.Performer) : (Flags & ~Flag.Performer); } }
		public bool HasWaveform { get { return Flags.HasFlag(Flag.Waveform); } set { Flags = value ? (Flags | Flag.Waveform) : (Flags & ~Flag.Waveform); } }

		public Flag Flags { get; set; }
		public String Title { get; set; }
		public String Performer { get; set; }
		public Byte[] Waveform { get; set; }

		public TLDocumentAttributeAudio() { }
		public TLDocumentAttributeAudio(TLBinaryReader from, TLType type = TLType.DocumentAttributeAudio)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeAudio; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.DocumentAttributeAudio)
		{
			Flags = (Flag)from.ReadInt32();
			Duration = from.ReadInt32();
			if (HasTitle) { Title = from.ReadString(); }
			if (HasPerformer) { Performer = from.ReadString(); }
			if (HasWaveform) { Waveform = from.ReadByteArray(); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9852F9C6);
			to.Write((Int32)Flags);
			to.Write(Duration);
			if (HasTitle) to.Write(Title);
			if (HasPerformer) to.Write(Performer);
			if (HasWaveform) to.WriteByteArray(Waveform);
		}
	}
}