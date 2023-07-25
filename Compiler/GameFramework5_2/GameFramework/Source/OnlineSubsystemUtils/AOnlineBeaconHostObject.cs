#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeaconHostObject.h")]
///<summary>Base class for any unique beacon connectivity, paired with an AOnlineBeaconClient implementation</summary>
public partial class AOnlineBeaconHostObject : AActor {
// OnlineBeaconHostObject
	public string BeaconTypeName;
	public UClass ClientBeaconActorClass;
	public TArray<AOnlineBeaconClient> ClientActors;
}
