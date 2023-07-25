#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Base class for all message data sent through concert</summary>
public partial struct FConcertMessageData {
// ConcertMessageData
	public FGuid ConcertEndpointId;
	public FGuid MessageId;
	public ushort MessageOrderIndex;
	public ushort ChannelId;
}
