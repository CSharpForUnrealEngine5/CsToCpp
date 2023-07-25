#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Acknowledgment messages to reliable events</summary>
public partial struct FConcertAckData {
// ConcertAckData
	public long AckSendTimeTicks;
	public FGuid SourceMessageId;
}
