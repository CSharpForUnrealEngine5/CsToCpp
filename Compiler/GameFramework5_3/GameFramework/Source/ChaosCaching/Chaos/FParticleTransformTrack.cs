namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosCache.h")]
public partial struct FParticleTransformTrack {
	public FRawAnimSequenceTrack RawTransformTrack;
	public float BeginOffset;
	public bool bDeactivateOnEnd;
	public TArray<float> KeyTimestamps;
}
