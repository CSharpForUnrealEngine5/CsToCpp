#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODManagerTool.h")]
public partial class ULODManagerPreviewLODProperties : UInteractiveToolPropertySet {
	///<summary>LOD to visualise. Default option is equivalent to disabling the Tool, RenderData is the mesh used for rendering derived from the SourceModel (possibly simplified)</summary>
	public string VisibleLOD;
	///<summary>GetLODNamesFunc</summary>
	public  TArray<string> GetLODNamesFunc() { return default; }
	///<summary>LODNamesList</summary>
	public TArray<string> LODNamesList;
	///<summary>Control whether mesh borders are displayed</summary>
	public bool bShowSeams;
}
