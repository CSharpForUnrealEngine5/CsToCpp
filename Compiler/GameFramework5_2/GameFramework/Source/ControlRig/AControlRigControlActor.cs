namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigControlActor.h")]
public partial class AControlRigControlActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ActorToTrack</summary>
	public AActor ActorToTrack;
	///<summary>ControlRigClass</summary>
	public UClass ControlRigClass;
	///<summary>bRefreshOnTick</summary>
	public bool bRefreshOnTick;
	///<summary>bIsSelectable</summary>
	public bool bIsSelectable;
	///<summary>MaterialOverride</summary>
	public UMaterialInterface MaterialOverride;
	///<summary>ColorParameter</summary>
	public string ColorParameter;
	///<summary>bCastShadows</summary>
	public bool bCastShadows;
	///<summary>ResetControlActor</summary>
	public void ResetControlActor() {}
	///<summary>Clear</summary>
	public void Clear() {}
	///<summary>Refresh</summary>
	public void Refresh() {}
	///<summary>ActorRootComponent</summary>
	public USceneComponent ActorRootComponent;
	///<summary>ControlRig</summary>
	public TSoftObjectPtr<UControlRig> ControlRig;
	///<summary>ControlNames</summary>
	public TArray<FName> ControlNames;
	///<summary>ShapeTransforms</summary>
	public TArray<FTransform> ShapeTransforms;
	///<summary>Components</summary>
	public TArray<UStaticMeshComponent> Components;
	///<summary>Materials</summary>
	public TArray<UMaterialInstanceDynamic> Materials;
	///<summary>ColorParameterName</summary>
	public FName ColorParameterName;
}
