#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/MaterialEditorOptions.h")]
public partial class UMaterialEditorOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, render grid the preview scene.</summary>
	public bool bShowGrid;
	///<summary>If true, don&#39;t render connectors that are not connected to anything.</summary>
	public bool bHideUnusedConnectorsSetting;
	///<summary>If true, the 3D material preview viewport updates in realtime.</summary>
	public bool bRealtimeMaterialViewport;
	///<summary>If true, the linked object viewport updates in realtime.</summary>
	public bool bRealtimeExpressionViewport;
	///<summary>If true, always refresh the material preview.</summary>
	public bool bLivePreviewUpdate;
	///<summary>If true, fade nodes which are not connected to the selected nodes</summary>
	public bool bHideUnrelatedNodes;
	///<summary>If true, always refresh all expression previews.</summary>
	public bool bAlwaysRefreshAllPreviews;
	///<summary>If false, use expression categorized menus.</summary>
	public bool bUseUnsortedMenus;
	///<summary>The users favorite material expressions.</summary>
	public TArray<string> FavoriteExpressions;
}
