namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAssetEditorSubsystem</summary>
[CppInclude("Subsystems/AssetEditorSubsystem.h")]
public partial class UAssetEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Tries to open an editor for all of the specified assets.</summary>
	public bool OpenEditorForAssets(TArray<UObject> Assets,EAssetTypeActivationOpenedMethod OpenedMethod/*=EAssetTypeActivationOpenedMethod.Edit*/) { return default; }
	///<summary>Close all active editors for the supplied asset and return the number of asset editors that were closed</summary>
	public int CloseAllEditorsForAsset(UObject Asset) { return default; }
	///<summary>OwnedAssetEditors</summary>
	public TArray<UAssetEditor> OwnedAssetEditors;
}
