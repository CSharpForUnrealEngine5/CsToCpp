#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLifeCycleComponent.h")]
public partial class UARLifeCycleComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Called when an AR actor is spawned on the server</summary>
	public  void FInstanceARActorSpawnedDelegate(UClass ComponentClass,FGuid NativeID,AARActor SpawnedActor) {}
	///<summary>OnARActorSpawnedDelegate</summary>
	public FInstanceARActorSpawnedDelegate OnARActorSpawnedDelegate;
	///<summary>Called just before the AR actor is destroyed on the server</summary>
	public  void FInstanceARActorToBeDestroyedDelegate(AARActor Actor) {}
	///<summary>OnARActorToBeDestroyedDelegate</summary>
	public FInstanceARActorToBeDestroyedDelegate OnARActorToBeDestroyedDelegate;
	///<summary>ServerSpawnARActor</summary>
	public  void ServerSpawnARActor(UClass ComponentClass,FGuid NativeID) {}
	///<summary>ServerDestroyARActor</summary>
	public  void ServerDestroyARActor(AARActor Actor) {}
}
