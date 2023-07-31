#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UBaseMeshProcessingTool is a base Tool (ie has no functionality of it&#39;s own and must be subclassed)</summary>
[CppInclude("BaseTools/BaseMeshProcessingTool.h")]
public partial class UBaseMeshProcessingTool : USingleSelectionTool {
	///<summary>Preview object holds temporary Actor with preview mesh component</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
