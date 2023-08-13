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
