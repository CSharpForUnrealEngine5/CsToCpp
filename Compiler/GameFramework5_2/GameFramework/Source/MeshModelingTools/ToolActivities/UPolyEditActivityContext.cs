namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditActivityContext.h")]
public partial class UPolyEditActivityContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CommonProperties</summary>
	public UPolyEditCommonProperties CommonProperties;
	///<summary>The mesh stored in the preview is not authoritative. It may be altered in various ways as the</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>The activity may use the selection mechanic to get (or alter) the current selection, though</summary>
	public UPolygonSelectionMechanic SelectionMechanic;
}
