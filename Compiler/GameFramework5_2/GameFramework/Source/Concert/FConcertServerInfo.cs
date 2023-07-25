#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds info on a Concert server</summary>
public partial struct FConcertServerInfo {
// ConcertServerInfo
	public FGuid AdminEndpointId;
	public string ServerName;
	public FConcertInstanceInfo InstanceInfo;
	public EConcertServerFlags ServerFlags;
}
