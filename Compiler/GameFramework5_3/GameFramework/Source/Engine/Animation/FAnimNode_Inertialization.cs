namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_Inertialization.h")]
public partial struct FAnimNode_Inertialization {
	public FPoseLink Source;
	public UBlendProfile DefaultBlendProfile;
	public TArray<FName> FilteredCurves;
	public bool bPreallocateMemory;
	public TArray<FInertializationRequest> RequestQueue;
	public UObject InertializationRequestAnimInstance;
}
