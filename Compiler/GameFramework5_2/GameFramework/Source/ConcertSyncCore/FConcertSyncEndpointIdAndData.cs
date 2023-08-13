namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ID and data pair for an endpoint in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncEndpointIdAndData {
	public FGuid EndpointId;
	public FConcertSyncEndpointData EndpointData;
}
