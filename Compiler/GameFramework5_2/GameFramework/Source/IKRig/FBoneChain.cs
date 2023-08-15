namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial struct FBoneChain {
	public FName ChainName;
	public FBoneReference StartBone;
	public FBoneReference EndBone;
	public FName IKGoalName;
}
