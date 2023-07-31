#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Drives an array of items through a harmonics spectrum</summary>
[CppInclude("Units/Highlevel/Harmonics/RigUnit_BoneHarmonics.h")]
public partial struct FRigUnit_ItemHarmonics {
	public TArray<FRigUnit_Harmonics_TargetItem> Targets;
	public FVector WaveSpeed;
	public FVector WaveFrequency;
	public FVector WaveAmplitude;
	public FVector WaveOffset;
	public FVector WaveNoise;
	public ERigVMAnimEasingType WaveEase;
	public float WaveMinimum;
	public float WaveMaximum;
	public EEulerRotationOrder RotationOrder;
	public FRigUnit_BoneHarmonics_WorkData WorkData;
}
