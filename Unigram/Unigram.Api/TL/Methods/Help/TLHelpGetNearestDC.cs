// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getNearestDc
	/// </summary>
	public partial class TLHelpGetNearestDC : TLObject
	{
		public TLHelpGetNearestDC() { }
		public TLHelpGetNearestDC(TLBinaryReader from, TLType type = TLType.HelpGetNearestDC)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.HelpGetNearestDC; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.HelpGetNearestDC)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1FB33026);
		}
	}
}