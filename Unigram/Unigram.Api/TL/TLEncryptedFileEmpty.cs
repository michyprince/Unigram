// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedFileEmpty : TLEncryptedFileBase 
	{
		public TLEncryptedFileEmpty() { }
		public TLEncryptedFileEmpty(TLBinaryReader from, TLType type = TLType.EncryptedFileEmpty)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.EncryptedFileEmpty; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.EncryptedFileEmpty)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC21F497E);
		}
	}
}