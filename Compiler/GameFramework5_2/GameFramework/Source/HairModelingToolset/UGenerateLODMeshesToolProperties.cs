#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenerateLODMeshesTool.h")]
///<summary>Standard properties of the Simplify operation</summary>
public partial class UGenerateLODMeshesToolProperties : UMeshConstraintProperties {
// GenerateLODMeshesToolProperties
	public ESimplifyTargetType TargetMode;
	public ESimplifyType SimplifierType;
	public int NameIndexBase;
	public int TargetPercentage;
	public float TargetEdgeLength;
	public int TargetCount;
	public bool bDiscardAttributes;
	public bool bShowWireframe;
	public bool bShowGroupColors;
	public bool bReproject;
	public TArray<FLODLevelGenerateSettings> LODLevels;
}
