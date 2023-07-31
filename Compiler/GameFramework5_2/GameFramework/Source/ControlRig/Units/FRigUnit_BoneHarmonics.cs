#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Performs point based simulation</summary>
[CppInclude("Units/Highlevel/Harmonics/RigUnit_BoneHarmonics.h")]
public partial struct FRigUnit_BoneHarmonics {
	public TArray<FRigUnit_BoneHarmonics_BoneTarget> Bones;
	public FVector WaveSpeed;
	public FVector WaveFrequency;
	public FVector WaveAmplitude;
	public FVector WaveOffset;
	public FVector WaveNoise;
	public ERigVMAnimEasingType WaveEase;
	public float WaveMinimum;
	public float WaveMaximum;
	public EEulerRotationOrder RotationOrder;
	public bool bPropagateToChildren;
	public FRigUnit_BoneHarmonics_WorkData WorkData;
}
