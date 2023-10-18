namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that can be used to store tool settings as a named preset</summary>
[CppInclude("ToolPresetAsset.h")]
public partial class UInteractiveToolsPresetCollectionAsset : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Currently there are no helper methods within this class, simply providing</summary>
	public TMap<string,FInteractiveToolPresetStore> PerToolPresets;
	///<summary>CollectionLabel</summary>
	public FText CollectionLabel;
}
