#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenerateLODMeshesTool.h")]
public partial struct FLODLevelGenerateSettings {
// LODLevelGenerateSettings
	public ESimplifyType SimplifierType;
	public ESimplifyTargetType TargetMode;
	public int TargetPercentage;
	public int TargetCount;
	public bool bReproject;
	public string Result;
}
