#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all unit tests depending upon a MinimalClient connecting to a server.</summary>
[CppInclude("ClientUnitTest.h")]
public partial class UClientUnitTest : UProcessUnitTest {
	public static UClass StaticClass() {return default;}
	///<summary>Actors the server is allowed replicate to client (requires AllowActors flag). Use NotifyAllowNetActor for conditional allows.</summary>
	public TArray<UClass> AllowedClientActors;
	///<summary>The object which handles implementation of the minimal client</summary>
	public UMinimalClient MinClient;
	///<summary>Stores a reference to the replicated PlayerController (if set to wait for this), after NotifyHandleClientPlayer</summary>
	public TWeakObjectPtr<APlayerController> UnitPC;
	///<summary>If EUnitTestFlags::RequireNUTActor is set, stores a reference to the replicated NUTActor</summary>
	public TWeakObjectPtr<ANUTActor> UnitNUTActor;
	///<summary>If EUnitTestFlags::RequireBeacon is set, stores a reference to the replicated beacon</summary>
	public TWeakObjectPtr<AActor> UnitBeacon;
	///<summary>Cached reference to the OnlineBeaconClient static class</summary>
	public UClass OnlineBeaconClass_Private;
}
