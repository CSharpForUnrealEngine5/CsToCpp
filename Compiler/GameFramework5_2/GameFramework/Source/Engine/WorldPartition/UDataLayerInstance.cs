#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerInstance.h")]
public partial class UDataLayerInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetType</summary>
	public  EDataLayerType GetType() { return default; }
	///<summary>IsInitiallyVisible</summary>
	public  bool IsInitiallyVisible() { return default; }
	///<summary>IsVisible</summary>
	public  bool IsVisible() { return default; }
	///<summary>IsEffectiveVisible</summary>
	public  bool IsEffectiveVisible() { return default; }
	///<summary>IsRuntime</summary>
	public  bool IsRuntime() { return default; }
	///<summary>GetDebugColor</summary>
	public  FColor GetDebugColor() { return default; }
	///<summary>GetInitialRuntimeState</summary>
	public  EDataLayerRuntimeState GetInitialRuntimeState() { return default; }
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
	///<summary>InitialRuntimeState</summary>
	public EDataLayerRuntimeState InitialRuntimeState;
	///<summary>Parent</summary>
	public UDataLayerInstance Parent;
	///<summary>Children</summary>
	public TArray<UDataLayerInstance> Children;
}
