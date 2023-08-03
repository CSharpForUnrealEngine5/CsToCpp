#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GlobalEditorUtilityBase.h")]
public partial class UDEPRECATED_GlobalEditorUtilityBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>HelpText</summary>
	public string HelpText;
	///<summary>bDirtiedSelectionSet</summary>
	public bool bDirtiedSelectionSet;
	///<summary>GetSelectionSet</summary>
	public  TArray<AActor> GetSelectionSet() { return default; }
	///<summary>Attempts to find the actor specified by PathToActor in the current editor world</summary>
	public  AActor GetActorReference(string PathToActor) { return default; }
	///<summary>Should this blueprint automatically run OnDefaultActionClicked, or should it open up a details panel to edit properties and/or offer multiple buttons</summary>
	public bool bAutoRunDefaultAction;
	///<summary>The default action called when the blutility is invoked if bAutoRunDefaultAction=true (it is never called otherwise)</summary>
	public  void OnDefaultActionClicked() {}
	///<summary>Calls OnEachSelectedActor for each selected actor</summary>
	public  void ForEachSelectedActor() {}
	///<summary>The method called for each selected actor when ForEachSelectedActor is called</summary>
	public FForEachActorIteratorSignature OnEachSelectedActor;
	///<summary>Calls OnEachSelectedAsset for each selected asset</summary>
	public  void ForEachSelectedAsset() {}
	///<summary>The method called for each selected asset when ForEachSelectedAsset is called</summary>
	public FForEachAssetIteratorSignature OnEachSelectedAsset;
	///<summary>Gets the set of currently selected assets</summary>
	public  TArray<UObject> GetSelectedAssets() { return default; }
	///<summary>GetEditorUserSettings</summary>
	public  UEditorPerProjectUserSettings GetEditorUserSettings() { return default; }
	///<summary>Remove all actors from the selection set</summary>
	public  void ClearActorSelectionSet() {}
	///<summary>Selects nothing in the editor (another way to clear the selection)</summary>
	public  void SelectNothing() {}
	///<summary>Set the selection state for the selected actor</summary>
	public  void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	///<summary>GetSelectionBounds</summary>
	public  void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	///<summary>Renames an asset (cannot move folders)</summary>
	public  void RenameAsset(UObject Asset,string NewName) {}
}
