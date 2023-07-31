#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FAnimationSetup {
	public UAnimSequence AnimSequence;
	public UClass AnimBlueprint;
	public FPerPlatformInt NumRandomizedInstances;
	public FPerPlatformBool Enabled;
}
