namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial struct FIKRetargetPose {
	public FVector RootTranslationOffset;
	public TMap<FName,FQuat> BoneRotationOffsets;
}
