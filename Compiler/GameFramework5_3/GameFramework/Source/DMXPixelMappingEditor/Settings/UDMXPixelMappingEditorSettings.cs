namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Layout options for the Pixel Mapping editor</summary>
[CppInclude("Settings/DMXPixelMappingEditorSettings.h")]
public partial class UDMXPixelMappingEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings for the hierarchy tab</summary>
	public FDMXPixelMappingHierarchySettings HierarchySettings;
	///<summary>Settings for the designer tab</summary>
	public FDMXPixelMappingDesignerSettings DesignerSettings;
}
