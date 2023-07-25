#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/VectorField/ParticleModuleVectorFieldLocal.h")]
public partial class UParticleModuleVectorFieldLocal : UParticleModuleVectorFieldBase {
// ParticleModuleVectorFieldLocal
	public UVectorField VectorField;
	public FVector RelativeTranslation;
	public FRotator RelativeRotation;
	public FVector RelativeScale3D;
	public float Intensity;
	public float Tightness;
	public bool bIgnoreComponentTransform;
	public bool bTileX;
	public bool bTileY;
	public bool bTileZ;
	public bool bUseFixDT;
}
