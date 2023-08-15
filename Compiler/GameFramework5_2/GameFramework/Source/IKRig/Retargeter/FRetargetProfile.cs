namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetProfile.h")]
public partial struct FRetargetProfile {
	public bool bApplyTargetRetargetPose;
	public FName TargetRetargetPoseName;
	public bool bApplySourceRetargetPose;
	public FName SourceRetargetPoseName;
	public bool bApplyChainSettings;
	public TMap<FName,FTargetChainSettings> ChainSettings;
	public bool bApplyRootSettings;
	public FTargetRootSettings RootSettings;
	public bool bApplyGlobalSettings;
	public FRetargetGlobalSettings GlobalSettings;
}
