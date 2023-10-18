namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UBaseMeshProcessingTool is a base Tool (ie has no functionality of it&#39;s own and must be subclassed)</summary>
[CppInclude("BaseTools/BaseMeshProcessingTool.h")]
public partial class UBaseMeshProcessingTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Preview object holds temporary Actor with preview mesh component</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
