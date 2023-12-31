namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all message data sent through concert</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertMessageData {
	public FGuid ConcertEndpointId;
	public FGuid MessageId;
	public ushort MessageOrderIndex;
	public ushort ChannelId;
}
