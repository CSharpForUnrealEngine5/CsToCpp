namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implementation of IEditableToolPaletteConfigManager specific to ModelingMode, currently needed because we cannot have</summary>
[CppInclude("ModelingToolsEditablePaletteConfig.h")]
public partial class UModelingModeEditableToolPaletteConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>EditableToolPalettes</summary>
	public TMap<FName,FEditableToolPaletteSettings> EditableToolPalettes;
}
