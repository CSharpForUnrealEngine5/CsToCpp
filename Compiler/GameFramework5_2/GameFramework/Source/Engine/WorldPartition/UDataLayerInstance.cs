#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerInstance.h")]
public partial class UDataLayerInstance : UObject {
// DataLayerInstance
	public EDataLayerType GetType() { return default; }
	public bool IsInitiallyVisible() { return default; }
	public bool IsVisible() { return default; }
	public bool IsEffectiveVisible() { return default; }
	public bool IsRuntime() { return default; }
	public FColor GetDebugColor() { return default; }
	public EDataLayerRuntimeState GetInitialRuntimeState() { return default; }
	public bool bIsVisible;
	public bool bIsInitiallyVisible;
	public bool bIsInitiallyLoadedInEditor;
	public bool bIsLoadedInEditor;
	public bool bIsLoadedInEditorChangedByUserOperation;
	public bool bIsLocked;
	public EDataLayerRuntimeState InitialRuntimeState;
	public UDataLayerInstance Parent;
	public TArray<UDataLayerInstance> Children;
}
