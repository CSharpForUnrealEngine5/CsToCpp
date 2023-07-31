#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds info on a Concert server</summary>
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertServerInfo {
	public FGuid AdminEndpointId;
	public string ServerName;
	public FConcertInstanceInfo InstanceInfo;
	public EConcertServerFlags ServerFlags;
}
