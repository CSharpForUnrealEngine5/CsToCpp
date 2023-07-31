#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial struct FIKRetargetPose {
	public FVector RootTranslationOffset;
	public TMap<string,FQuat> BoneRotationOffsets;
}
