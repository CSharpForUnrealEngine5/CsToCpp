namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/SingleTargetWithSelectionTool.h")]
public partial class USingleTargetWithSelectionTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>GeometrySelectionVizProperties</summary>
	public UGeometrySelectionVisualizationProperties GeometrySelectionVizProperties;
	///<summary>GeometrySelectionViz</summary>
	public UPreviewGeometry GeometrySelectionViz;
}
