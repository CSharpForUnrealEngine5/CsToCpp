namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that can be used to store tool settings as a named preset</summary>
[CppInclude("PresetAsset.h")]
public partial class UInteractiveToolsPresetCollectionAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Currently there are no helper methods within this class, simply providing</summary>
	public TMap<string,FInteractiveToolPresetStore> PerToolPresets;
}
