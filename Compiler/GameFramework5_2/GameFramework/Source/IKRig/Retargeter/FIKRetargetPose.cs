#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial struct FIKRetargetPose {
// IKRetargetPose
	public FVector RootTranslationOffset;
	public TMap<string,FQuat> BoneRotationOffsets;
}
