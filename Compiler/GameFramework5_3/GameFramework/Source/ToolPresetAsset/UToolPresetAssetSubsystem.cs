namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Using an editor subsystem allows us to make sure that we have a default preset asset whenever the editor exists</summary>
[CppInclude("ToolPresetAssetSubsystem.h")]
public partial class UToolPresetAssetSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultCollection</summary>
	public UInteractiveToolsPresetCollectionAsset DefaultCollection;
}
