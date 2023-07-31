#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Layout options for the Pixel Mapping editor</summary>
[CppInclude("DMXPixelMappingLayoutSettings.h")]
public partial class UDMXPixelMappingLayoutSettings : UObject {
	///<summary>If true, scales children when the parent component is resized</summary>
	public bool bScaleChildrenWithParent;
	///<summary>If true, selects parent when a child is clicked</summary>
	public bool bAlwaysSelectGroup;
	///<summary>If true, applies layout scripts instantly when they are loaded</summary>
	public bool bApplyLayoutScriptWhenLoaded;
	///<summary>If true, shows the name of the Fixture Patch where applicable. May affect editor performance.</summary>
	public bool bShowComponentNames;
	///<summary>If true, shows Fixture info bout the Fixture Patch where applicable. May affect editor performance.</summary>
	public bool bShowPatchInfo;
	///<summary>If true, shows Cell IDs where applicable. May affect editor performance.</summary>
	public bool bShowCellIDs;
}
