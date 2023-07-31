#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureEditorMode.h")]
public partial class UFractureModeCustomizationSettings : UDeveloperSettings {
	///<summary>Add the names of Fracture Mode Tool Palette Sections to have them appear at the top of the Tool Palette, in the order listed below.</summary>
	public TArray<string> ToolSectionOrder;
	///<summary>Tool Names listed in the array below will appear in a Favorites section at the top of the Fracture Mode Tool Palette</summary>
	public TArray<string> ToolFavorites;
	///<summary>Custom Section Header Colors for listed Sections in the Fracture Mode Tool Palette</summary>
	public TArray<FFractureModeCustomSectionColor> SectionColors;
	///<summary>Custom Tool Colors for listed Tools in the Fracture Mode Tool Palette.</summary>
	public TArray<FFractureModeCustomToolColor> ToolColors;
}
