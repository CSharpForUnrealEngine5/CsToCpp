namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Acknowledgment messages to reliable events</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertAckData {
	public long AckSendTimeTicks;
	public FGuid SourceMessageId;
}
