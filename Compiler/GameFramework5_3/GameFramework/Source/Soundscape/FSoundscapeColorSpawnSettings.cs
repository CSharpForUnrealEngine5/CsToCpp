namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct</summary>
[CppInclude("SoundscapeColor.h")]
public partial struct FSoundscapeColorSpawnSettings {
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
	public ECollisionChannel TraceChannel;
	public bool bFilterByColorPointDensity;
	public FGameplayTag ColorPoint;
	public int MinColorPointNumber;
	public bool bIgnoreZAxisWhenCullingByMaxDistance;
}
