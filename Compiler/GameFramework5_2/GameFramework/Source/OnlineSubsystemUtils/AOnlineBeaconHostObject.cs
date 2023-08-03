#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for any unique beacon connectivity, paired with an AOnlineBeaconClient implementation</summary>
[CppInclude("OnlineBeaconHostObject.h")]
public partial class AOnlineBeaconHostObject : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Custom name for this beacon</summary>
	public string BeaconTypeName;
	///<summary>Class reference for spawning client beacon actor</summary>
	public UClass ClientBeaconActorClass;
	///<summary>List of all client beacon actors with active connections</summary>
	public TArray<AOnlineBeaconClient> ClientActors;
}
