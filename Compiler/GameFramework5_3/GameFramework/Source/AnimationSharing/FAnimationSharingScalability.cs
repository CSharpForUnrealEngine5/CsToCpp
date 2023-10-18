namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FAnimationSharingScalability {
	public FPerPlatformBool UseBlendTransitions;
	public FPerPlatformFloat BlendSignificanceValue;
	public FPerPlatformInt MaximumNumberConcurrentBlends;
	public FPerPlatformFloat TickSignificanceValue;
}
