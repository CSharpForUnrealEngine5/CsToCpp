#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClientUnitTest.h")]
///<summary>Base class for all unit tests depending upon a MinimalClient connecting to a server.</summary>
public partial class UClientUnitTest : UProcessUnitTest {
// ClientUnitTest
	public TArray<UClass> AllowedClientActors;
	public UMinimalClient MinClient;
	public TWeakObjectPtr<APlayerController> UnitPC;
	public TWeakObjectPtr<ANUTActor> UnitNUTActor;
	public TWeakObjectPtr<AActor> UnitBeacon;
	public UClass OnlineBeaconClass_Private;
}
