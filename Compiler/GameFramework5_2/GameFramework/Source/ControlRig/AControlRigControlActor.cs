#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigControlActor.h")]
public partial class AControlRigControlActor : AActor {
// ControlRigControlActor
	public AActor ActorToTrack;
	public UClass ControlRigClass;
	public bool bRefreshOnTick;
	public bool bIsSelectable;
	public UMaterialInterface MaterialOverride;
	public string ColorParameter;
	public bool bCastShadows;
	public  void ResetControlActor() {}
	public  void Clear() {}
	public  void Refresh() {}
	public USceneComponent ActorRootComponent;
	public TSoftObjectPtr<UControlRig> ControlRig;
	public TArray<string> ControlNames;
	public TArray<FTransform> ShapeTransforms;
	public TArray<UStaticMeshComponent> Components;
	public TArray<UMaterialInstanceDynamic> Materials;
	public string ColorParameterName;
}
