#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/AssetEditorSubsystem.h")]
///<summary>UAssetEditorSubsystem</summary>
public partial class UAssetEditorSubsystem : UEditorSubsystem {
// AssetEditorSubsystem
	public bool OpenEditorForAssets(TArray<UObject> Assets,EAssetTypeActivationOpenedMethod OpenedMethod/*=EAssetTypeActivationOpenedMethod.Edit*/) { return default; }
	public int CloseAllEditorsForAsset(UObject Asset) { return default; }
	public TArray<UAssetEditor> OwnedAssetEditors;
}
