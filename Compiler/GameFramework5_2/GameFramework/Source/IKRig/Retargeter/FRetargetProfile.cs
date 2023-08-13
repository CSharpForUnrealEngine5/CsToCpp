namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetProfile.h")]
public partial struct FRetargetProfile {
	public bool bApplyTargetRetargetPose;
	public string TargetRetargetPoseName;
	public bool bApplySourceRetargetPose;
	public string SourceRetargetPoseName;
	public bool bApplyChainSettings;
	public TMap<string,FTargetChainSettings> ChainSettings;
	public bool bApplyRootSettings;
	public FTargetRootSettings RootSettings;
	public bool bApplyGlobalSettings;
	public FRetargetGlobalSettings GlobalSettings;
}
