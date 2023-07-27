#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayer.h")]
public partial class UDEPRECATED_DataLayer : UObject {
// DataLayer
	public  bool Equals(FActorDataLayer ActorDataLayer) { return default; }
	public  string GetDataLayerLabel() { return default; }
	public  bool IsInitiallyVisible() { return default; }
	public  bool IsVisible() { return default; }
	public  bool IsEffectiveVisible() { return default; }
	public  FColor GetDebugColor() { return default; }
	public  bool IsRuntime() { return default; }
	public  EDataLayerRuntimeState GetInitialRuntimeState() { return default; }
	public  bool IsDynamicallyLoaded() { return default; }
	public  bool IsInitiallyActive() { return default; }
	public  EDataLayerState GetInitialState() { return default; }
	public bool bIsInitiallyActive_DEPRECATED;
	public bool bIsVisible;
	public bool bIsInitiallyVisible;
	public bool bIsInitiallyLoadedInEditor;
	public bool bIsLoadedInEditor;
	public bool bIsLoadedInEditorChangedByUserOperation;
	public bool bIsLocked;
	public string DataLayerLabel;
	public bool bIsRuntime;
	public EDataLayerRuntimeState InitialRuntimeState;
	public FColor DebugColor;
	public UDEPRECATED_DataLayer Parent_DEPRECATED;
	public TArray<UDEPRECATED_DataLayer> Children_DEPRECATED;
}
