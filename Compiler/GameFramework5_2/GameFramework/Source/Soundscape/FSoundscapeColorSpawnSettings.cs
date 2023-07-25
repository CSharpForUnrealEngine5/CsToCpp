#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
///<summary>Struct</summary>
public partial struct FSoundscapeColorSpawnSettings {
// SoundscapeColorSpawnSettings
	public bool bDelayFirstSpawn;
	public float MinFirstSpawnDelay;
	public float MaxFirstSpawnDelay;
	public bool bContinuouslyRespawn;
	public float MinSpawnDelay;
	public float MaxSpawnDelay;
	public int MaxNumberOfSpawnedElements;
	public float MinSpawnDistance;
	public float MaxSpawnDistance;
	public bool bCullByMaxSpawnDistance;
	public float MinSpawnAngle;
	public float MaxSpawnAngle;
	public bool bClampHeight;
	public ESoundscapeColorAltitudeClampMode ClampMode;
	public float MinSpawnHeightClamp;
	public float MaxSpawnHeightClamp;
	public bool bRotateSoundSource;
	public float MinAzimuthalRotationAngle;
	public float MaxAzimuthalRotationAngle;
	public float MinAltitudinalRotationAngle;
	public float MaxAltitudinalRotationAngle;
	public bool bPositionByTrace;
	public FVector TraceVector;
	public float TraceDistance;
	public byte TraceChannel;
	public bool bFilterByColorPointDensity;
	public FGameplayTag ColorPoint;
	public int MinColorPointNumber;
	public bool bIgnoreZAxisWhenCullingByMaxDistance;
}
