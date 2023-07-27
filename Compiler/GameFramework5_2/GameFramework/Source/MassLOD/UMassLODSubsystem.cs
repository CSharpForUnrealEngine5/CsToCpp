#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLODSubsystem.h")]
///<summary>* Manager responsible to manage and synchronized available viewers</summary>
public partial class UMassLODSubsystem : UTickableWorldSubsystem {
// MassLODSubsystem
	public  void OnPlayerControllerEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	public TArray<FViewerInfo> Viewers;
	public TMap<uint,FMassViewerHandle> ViewerMap;
}
