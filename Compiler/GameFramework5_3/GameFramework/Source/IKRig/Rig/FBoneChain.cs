namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/IKRigDefinition.h")]
public partial struct FBoneChain {
	public FName ChainName;
	public FBoneReference StartBone;
	public FBoneReference EndBone;
	public FName IKGoalName;
}
