#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Attenuation.h")]
///<summary>* Base class for attenuation settings.</summary>
public partial struct FBaseAttenuationSettings {
// BaseAttenuationSettings
	public EAttenuationDistanceModel DistanceAlgorithm;
	public byte AttenuationShape;
	public ENaturalSoundFalloffMode FalloffMode;
	public float dBAttenuationAtMax;
	public FVector AttenuationShapeExtents;
	public float ConeOffset;
	public float FalloffDistance;
	public float ConeSphereRadius;
	public float ConeSphereFalloffDistance;
	public FRuntimeFloatCurve CustomAttenuationCurve;
}
