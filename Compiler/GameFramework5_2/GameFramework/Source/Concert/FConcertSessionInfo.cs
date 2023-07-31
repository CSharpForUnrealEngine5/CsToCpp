#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds info on a session</summary>
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertSessionInfo {
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
