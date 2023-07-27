#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GlobalEditorUtilityBase.h")]
public partial class UDEPRECATED_GlobalEditorUtilityBase : UObject {
// GlobalEditorUtilityBase
	public string HelpText;
	public bool bDirtiedSelectionSet;
	public  TArray<AActor> GetSelectionSet() { return default; }
	public  AActor GetActorReference(string PathToActor) { return default; }
	public bool bAutoRunDefaultAction;
	public  void OnDefaultActionClicked() {}
	public  void ForEachSelectedActor() {}
	public FForEachActorIteratorSignature OnEachSelectedActor;
	public  void ForEachSelectedAsset() {}
	public FForEachAssetIteratorSignature OnEachSelectedAsset;
	public  TArray<UObject> GetSelectedAssets() { return default; }
	public  UEditorPerProjectUserSettings GetEditorUserSettings() { return default; }
	public  void ClearActorSelectionSet() {}
	public  void SelectNothing() {}
	public  void SetActorSelectionState(AActor Actor,bool bShouldBeSelected) {}
	public  void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public  void RenameAsset(UObject Asset,string NewName) {}
}
