#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties controlling how changes are baked out to static meshes on tool accept</summary>
[CppInclude("PlaneCutTool.h")]
public partial class UAcceptOutputProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>If true, meshes cut into multiple pieces will be saved as separate assets on &#39;accept&#39;.</summary>
	public bool bExportSeparatedPiecesAsNewMeshAssets;
}
