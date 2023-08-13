namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for attenuation settings.</summary>
[CppInclude("Engine/Attenuation.h")]
public partial struct FBaseAttenuationSettings {
	public EAttenuationDistanceModel DistanceAlgorithm;
	public EAttenuationShape AttenuationShape;
	public ENaturalSoundFalloffMode FalloffMode;
	public float dBAttenuationAtMax;
	public FVector AttenuationShapeExtents;
	public float ConeOffset;
	public float FalloffDistance;
	public float ConeSphereRadius;
	public float ConeSphereFalloffDistance;
	public FRuntimeFloatCurve CustomAttenuationCurve;
}
