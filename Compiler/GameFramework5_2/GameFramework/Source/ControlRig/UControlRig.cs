namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runs logic for mapping input data to transforms (the &quot;Rig&quot;)</summary>
[CppInclude("ControlRig.h")]
public partial class UControlRig : URigVMHost {
	public static UClass StaticClass() {return default;}
	///<summary>To support Blueprints/scripting, we need a different delegate type (a &#39;Dynamic&#39; delegate) which supports looser style UFunction binding (using names).</summary>
	public void FOnControlSelectedBP(UControlRig Rig,FRigControlElement Control,bool bSelected) {}
	///<summary>FindControlRigs</summary>
	public static TArray<UControlRig> FindControlRigs(UObject Outer,UClass OptionalClass) { return default; }
	///<summary>Creates a transformable control handle for the specified control to be used by the constraints system. Should use the UObject from</summary>
	public UTransformableControlHandle CreateTransformableControlHandle(UObject Outer,string ControlName) { return default; }
	///<summary>Find the actor the rig is bound to, if any</summary>
	public AActor GetHostingActor() { return default; }
	///<summary>GetHierarchy</summary>
	public URigHierarchy GetHierarchy() { return default; }
	///<summary>END UObject interface</summary>
	public ERigExecutionType ExecutionType;
	///<summary>HierarchySettings</summary>
	public FRigHierarchySettings HierarchySettings;
	///<summary>Requests to perform construction during the next execution</summary>
	public void RequestConstruction() {}
	///<summary>SelectControl</summary>
	public virtual void SelectControl(string InControlName,bool bSelect/*=true*/) {}
	///<summary>ClearControlSelection</summary>
	public virtual bool ClearControlSelection() { return default; }
	///<summary>CurrentControlSelection</summary>
	public virtual TArray<string> CurrentControlSelection() { return default; }
	///<summary>IsControlSelected</summary>
	public virtual bool IsControlSelected(string InControlName) { return default; }
	///<summary>ControlCustomizations</summary>
	public TMap<FRigElementKey,FRigControlElementCustomization> ControlCustomizations;
	///<summary>DynamicHierarchy</summary>
	public URigHierarchy DynamicHierarchy;
	///<summary>GizmoLibrary_DEPRECATED</summary>
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	///<summary>ShapeLibraries</summary>
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	///<summary>you either go Input or Output, currently if you put it in both place, Output will override</summary>
	public TMap<string,FCachedPropertyPath> InputProperties_DEPRECATED;
	///<summary>OutputProperties_DEPRECATED</summary>
	public TMap<string,FCachedPropertyPath> OutputProperties_DEPRECATED;
	///<summary>The registry to access data source</summary>
	public UAnimationDataSourceRegistry DataSourceRegistry;
	///<summary>Influences</summary>
	public FRigInfluenceMapPerEvent Influences;
	///<summary>InteractionRig</summary>
	public UControlRig InteractionRig;
	///<summary>InteractionRigClass</summary>
	public UClass InteractionRigClass;
	///<summary>GetInteractionRig</summary>
	public UControlRig GetInteractionRig() { return default; }
	///<summary>SetInteractionRig</summary>
	public void SetInteractionRig(UControlRig InInteractionRig) {}
	///<summary>GetInteractionRigClass</summary>
	public UClass GetInteractionRigClass() { return default; }
	///<summary>SetInteractionRigClass</summary>
	public void SetInteractionRigClass(UClass InInteractionRigClass) {}
	///<summary>OnControlSelected_BP</summary>
	public FOnControlSelectedBP OnControlSelected_BP;
	///<summary>Whether controls are visible</summary>
	public bool bControlsVisible;
}
