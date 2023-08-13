namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/HashSettings.h")]
public partial struct FHashSettings {
	public double HashCutoffSeconds;
	public bool bUseHashForLoading;
	public bool bCanUseCRC;
	public bool bCanUseMD5;
	public EHashAlgorithmChooseBehavior SnapshotDiffAlgorithm;
}
