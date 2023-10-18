namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the SmartObject asset editor</summary>
[CppInclude("SmartObjectAssetEditorSettings.h")]
public partial class USmartObjectAssetEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Indicates whether or not the grid must be shown by default when the editor is opened</summary>
	public bool bShowGridByDefault;
}
