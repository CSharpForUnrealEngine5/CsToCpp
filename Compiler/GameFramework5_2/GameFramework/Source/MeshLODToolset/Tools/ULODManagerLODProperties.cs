#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODManagerTool.h")]
public partial class ULODManagerLODProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>SourceLODs</summary>
	public TArray<FLODManagerLODInfo> SourceLODs;
	///<summary>HiResSource</summary>
	public TArray<FLODManagerLODInfo> HiResSource;
	///<summary>RenderLODs</summary>
	public TArray<FLODManagerLODInfo> RenderLODs;
	///<summary>bNaniteEnabled</summary>
	public bool bNaniteEnabled;
	///<summary>PercentTriangles</summary>
	public float PercentTriangles;
	///<summary>Materials</summary>
	public TArray<FStaticMaterial> Materials;
}
