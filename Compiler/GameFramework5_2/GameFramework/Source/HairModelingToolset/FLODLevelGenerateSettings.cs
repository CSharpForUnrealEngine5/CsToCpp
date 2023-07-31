#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenerateLODMeshesTool.h")]
public partial struct FLODLevelGenerateSettings {
	public ESimplifyType SimplifierType;
	public ESimplifyTargetType TargetMode;
	public int TargetPercentage;
	public int TargetCount;
	public bool bReproject;
	public string Result;
}
