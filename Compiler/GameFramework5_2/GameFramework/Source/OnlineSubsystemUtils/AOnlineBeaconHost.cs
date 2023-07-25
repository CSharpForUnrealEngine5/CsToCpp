#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeaconHost.h")]
///<summary>Main actor that listens for side channel communication from another Unreal Engine application</summary>
public partial class AOnlineBeaconHost : AOnlineBeacon {
// OnlineBeaconHost
	public int ListenPort;
	public bool bAuthRequired;
	public uint MaxAuthTokenSize;
	public TArray<AOnlineBeaconClient> ClientActors;
}
