#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODManagerTool.h")]
public partial class ULODManagerLODProperties : UInteractiveToolPropertySet {
// LODManagerLODProperties
	public TArray<FLODManagerLODInfo> SourceLODs;
	public TArray<FLODManagerLODInfo> HiResSource;
	public TArray<FLODManagerLODInfo> RenderLODs;
	public bool bNaniteEnabled;
	public float PercentTriangles;
	public TArray<FStaticMaterial> Materials;
}
