#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_Inertialization.h")]
public partial struct FAnimNode_Inertialization {
	public FPoseLink Source;
	public UBlendProfile DefaultBlendProfile;
	public TArray<string> FilteredCurves;
	public TArray<FInertializationRequest> RequestQueue;
}
