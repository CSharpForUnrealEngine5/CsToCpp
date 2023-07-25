#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds info on a session</summary>
public partial struct FConcertSessionInfo {
// ConcertSessionInfo
	public FGuid ServerInstanceId;
	public FGuid ServerEndpointId;
	public FGuid OwnerInstanceId;
	public FGuid SessionId;
	public string SessionName;
	public string OwnerUserName;
	public string OwnerDeviceName;
	public FConcertSessionSettings Settings;
	public TArray<FConcertSessionVersionInfo> VersionInfos;
	public EConcertSessionState State;
	public long LastModifiedTicks;
}
