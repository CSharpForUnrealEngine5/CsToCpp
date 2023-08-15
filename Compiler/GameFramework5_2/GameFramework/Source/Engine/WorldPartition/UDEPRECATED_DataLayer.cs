namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayer.h")]
public partial class UDEPRECATED_DataLayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Equals</summary>
	public bool Equals(FActorDataLayer ActorDataLayer) { return default; }
	///<summary>GetDataLayerLabel</summary>
	public FName GetDataLayerLabel() { return default; }
	///<summary>IsInitiallyVisible</summary>
	public bool IsInitiallyVisible() { return default; }
	///<summary>IsVisible</summary>
	public bool IsVisible() { return default; }
	///<summary>IsEffectiveVisible</summary>
	public bool IsEffectiveVisible() { return default; }
	///<summary>GetDebugColor</summary>
	public FColor GetDebugColor() { return default; }
	///<summary>IsRuntime</summary>
	public bool IsRuntime() { return default; }
	///<summary>GetInitialRuntimeState</summary>
	public EDataLayerRuntimeState GetInitialRuntimeState() { return default; }
	///<summary>IsDynamicallyLoaded</summary>
	public bool IsDynamicallyLoaded() { return default; }
	///<summary>IsInitiallyActive</summary>
	public bool IsInitiallyActive() { return default; }
	///<summary>GetInitialState</summary>
	public EDataLayerState GetInitialState() { return default; }
	///<summary>bIsInitiallyActive_DEPRECATED</summary>
	public bool bIsInitiallyActive_DEPRECATED;
	///<summary>Whether actors associated with the DataLayer are visible in the viewport</summary>
	public bool bIsVisible;
	///<summary>Whether actors associated with the Data Layer should be initially visible in the viewport when loading the map</summary>
	public bool bIsInitiallyVisible;
	///<summary>Determines the default value of the data layer&#39;s loaded state in editor if it hasn&#39;t been changed in data layer outliner by the user</summary>
	public bool bIsInitiallyLoadedInEditor;
	///<summary>Wheter the data layer is loaded in editor (user setting)</summary>
	public bool bIsLoadedInEditor;
	///<summary>Whether this data layer editor visibility was changed by a user operation</summary>
	public bool bIsLoadedInEditorChangedByUserOperation;
	///<summary>Whether this data layer is locked, which means the user can&#39;t change actors assignation, remove or rename it</summary>
	public bool bIsLocked;
	///<summary>The display name of the Data Layer</summary>
	public FName DataLayerLabel;
	///<summary>Whether the Data Layer affects actor runtime loading</summary>
	public bool bIsRuntime;
	///<summary>InitialRuntimeState</summary>
	public EDataLayerRuntimeState InitialRuntimeState;
	///<summary>DebugColor</summary>
	public FColor DebugColor;
	///<summary>Parent_DEPRECATED</summary>
	public UDEPRECATED_DataLayer Parent_DEPRECATED;
	///<summary>Children_DEPRECATED</summary>
	public TArray<UDEPRECATED_DataLayer> Children_DEPRECATED;
}
