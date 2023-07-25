#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier.h")]
public partial class UGeomModifier : UObject {
// GeomModifier
	public string Description;
	public string Tooltip;
	public string ToolbarIconName;
	public bool bPushButton;
	public bool bInitialized;
	public bool bPendingPivotOffsetUpdate;
	public bool bAppearsInToolbar;
	public UPolys CachedPolys;
}
