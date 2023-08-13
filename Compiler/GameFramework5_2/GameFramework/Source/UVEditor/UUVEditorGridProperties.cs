namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings for the UUVEditorMode&#39;s Grid</summary>
[CppInclude("UVEditorMode.h")]
public partial class UUVEditorGridProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Should the grid be shown?</summary>
	public bool bDrawGrid;
	///<summary>Should the grid rulers be shown?</summary>
	public bool bDrawRulers;
}
