namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FAnimationSetup {
	public UAnimSequence AnimSequence;
	public UClass AnimBlueprint;
	public FPerPlatformInt NumRandomizedInstances;
	public FPerPlatformBool Enabled;
}
