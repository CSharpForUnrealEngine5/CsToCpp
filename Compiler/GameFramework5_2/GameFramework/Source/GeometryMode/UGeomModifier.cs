namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier.h")]
public partial class UGeomModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A human readable name for this modifier (appears on buttons, menus, etc)</summary>
	public FText Description;
	///<summary>The tooltip to be displayed for this modifier</summary>
	public FText Tooltip;
	///<summary>Icon name for showing this modifier in a toolbar</summary>
	public string ToolbarIconName;
	///<summary>If true, this modifier should be displayed as a push button instead of a radio button</summary>
	public bool bPushButton;
	///<summary>true if the modifier has been initialized.</summary>
	public bool bInitialized;
	///<summary>If true, the pivot offset should be updated when the modification ends</summary>
	public bool bPendingPivotOffsetUpdate;
	///<summary>bAppearsInToolbar</summary>
	public bool bAppearsInToolbar;
	///<summary>Stored state of polys in case the brush state needs to be restroed</summary>
	public UPolys CachedPolys;
}
