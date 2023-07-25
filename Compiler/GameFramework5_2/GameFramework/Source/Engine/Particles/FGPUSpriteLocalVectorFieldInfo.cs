#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
///<summary>Data needed for local vector fields.</summary>
public partial struct FGPUSpriteLocalVectorFieldInfo {
// GPUSpriteLocalVectorFieldInfo
	public UVectorField Field;
	public FTransform Transform;
	public FRotator MinInitialRotation;
	public FRotator MaxInitialRotation;
	public FRotator RotationRate;
	public float Intensity;
	public float Tightness;
	public bool bIgnoreComponentTransform;
	public bool bTileX;
	public bool bTileY;
	public bool bTileZ;
	public bool bUseFixDT;
}
