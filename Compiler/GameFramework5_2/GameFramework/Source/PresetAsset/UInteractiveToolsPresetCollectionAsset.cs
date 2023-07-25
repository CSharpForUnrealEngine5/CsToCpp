#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PresetAsset.h")]
///<summary>Implements an asset that can be used to store tool settings as a named preset</summary>
public partial class UInteractiveToolsPresetCollectionAsset : UObject {
// InteractiveToolsPresetCollectionAsset
	public TMap<string,FInteractiveToolPresetStore> PerToolPresets;
}
