namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Main actor that listens for side channel communication from another Unreal Engine application</summary>
[CppInclude("OnlineBeaconHost.h")]
public partial class AOnlineBeaconHost : AOnlineBeacon {
	public static UClass StaticClass() {return default;}
	///<summary>Configured listen port for this beacon host</summary>
	public int ListenPort;
	///<summary>Set this to true if you require clients to negotiate auth prior to joining the beacon</summary>
	public bool bAuthRequired;
	///<summary>MaxAuthTokenSize</summary>
	public uint MaxAuthTokenSize;
	///<summary>List of all client beacon actors with active connections</summary>
	public TArray<AOnlineBeaconClient> ClientActors;
}
