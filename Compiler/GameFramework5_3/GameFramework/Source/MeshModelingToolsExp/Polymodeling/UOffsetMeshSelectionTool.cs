namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/OffsetMeshSelectionTool.h")]
public partial class UOffsetMeshSelectionTool : USingleTargetWithSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>OffsetProperties</summary>
	public UOffsetMeshSelectionToolProperties OffsetProperties;
	///<summary>SourcePreview</summary>
	public UPreviewMesh SourcePreview;
	///<summary>EditCompute</summary>
	public UMeshOpPreviewWithBackgroundCompute EditCompute;
}
