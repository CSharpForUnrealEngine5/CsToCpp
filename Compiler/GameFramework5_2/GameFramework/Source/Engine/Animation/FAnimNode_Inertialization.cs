#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_Inertialization.h")]
public partial struct FAnimNode_Inertialization {
// AnimNode_Inertialization
	public FPoseLink Source;
	public UBlendProfile DefaultBlendProfile;
	public TArray<string> FilteredCurves;
	public TArray<FInertializationRequest> RequestQueue;
}
