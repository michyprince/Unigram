// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLStorageFilePdf : TLStorageFileTypeBase 
	{
		public TLStorageFilePdf() { }
		public TLStorageFilePdf(TLBinaryReader from, TLType type = TLType.StorageFilePdf)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.StorageFilePdf; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.StorageFilePdf)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAE1E508D);
		}
	}
}