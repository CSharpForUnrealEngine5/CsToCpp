#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Weld Edges Tool</summary>
[CppInclude("WeldMeshEdgesTool.h")]
public partial class UWeldMeshEdgesTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UWeldMeshEdgesToolProperties Settings;
	///<summary>PreviewCompute</summary>
	public UMeshOpPreviewWithBackgroundCompute PreviewCompute;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
	///<summary>OperatorFactory</summary>
	public UWeldMeshEdgesOperatorFactory OperatorFactory;
}
