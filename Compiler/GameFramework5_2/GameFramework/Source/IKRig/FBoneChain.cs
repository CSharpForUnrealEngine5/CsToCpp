#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial struct FBoneChain {
	public string ChainName;
	public FBoneReference StartBone;
	public FBoneReference EndBone;
	public string IKGoalName;
}
