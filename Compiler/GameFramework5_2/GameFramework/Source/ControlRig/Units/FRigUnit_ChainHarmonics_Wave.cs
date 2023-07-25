#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Harmonics/RigUnit_ChainHarmonics.h")]
public partial struct FRigUnit_ChainHarmonics_Wave {
// RigUnit_ChainHarmonics_Wave
	public bool bEnabled;
	public FVector WaveFrequency;
	public FVector WaveAmplitude;
	public FVector WaveOffset;
	public FVector WaveNoise;
	public float WaveMinimum;
	public float WaveMaximum;
	public ERigVMAnimEasingType WaveEase;
}
