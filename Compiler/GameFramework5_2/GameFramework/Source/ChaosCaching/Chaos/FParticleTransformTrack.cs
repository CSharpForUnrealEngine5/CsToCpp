#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosCache.h")]
public partial struct FParticleTransformTrack {
// ParticleTransformTrack
	public FRawAnimSequenceTrack RawTransformTrack;
	public float BeginOffset;
	public bool bDeactivateOnEnd;
	public TArray<float> KeyTimestamps;
}
