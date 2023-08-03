#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Manager responsible to manage and synchronized available viewers</summary>
[CppInclude("MassLODSubsystem.h")]
public partial class UMassLODSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Player controller EndPlay callback, removing viewers from the list</summary>
	public  void OnPlayerControllerEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	///<summary>The actual array of viewer&#39;s information</summary>
	public TArray<FViewerInfo> Viewers;
	///<summary>The map that do reverse look up to get ViewerHandle</summary>
	public TMap<uint,FMassViewerHandle> ViewerMap;
}
