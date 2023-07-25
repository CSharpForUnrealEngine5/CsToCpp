#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FAnimationSetup {
// AnimationSetup
	public UAnimSequence AnimSequence;
	public UClass AnimBlueprint;
	public FPerPlatformInt NumRandomizedInstances;
	public FPerPlatformBool Enabled;
}
