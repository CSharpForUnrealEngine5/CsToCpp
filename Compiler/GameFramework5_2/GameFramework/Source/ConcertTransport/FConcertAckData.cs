#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Acknowledgment messages to reliable events</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertAckData {
	public long AckSendTimeTicks;
	public FGuid SourceMessageId;
}
