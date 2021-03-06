// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentEmpty : TLDocumentBase 
	{

		public TLDocumentEmpty() { }
		public TLDocumentEmpty(TLBinaryReader from, TLType type = TLType.DocumentEmpty)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.DocumentEmpty; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.DocumentEmpty)
		{
			Id = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x36F8C871);
			to.Write(Id);
		}
	}
}