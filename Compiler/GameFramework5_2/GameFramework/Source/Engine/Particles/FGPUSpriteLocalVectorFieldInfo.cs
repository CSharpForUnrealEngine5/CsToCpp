#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data needed for local vector fields.</summary>
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
public partial struct FGPUSpriteLocalVectorFieldInfo {
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
