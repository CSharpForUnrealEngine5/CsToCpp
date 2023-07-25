#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataMesh.h")]
public partial class UParticleModuleTypeDataMesh : UParticleModuleTypeDataBase {
// ParticleModuleTypeDataMesh
	public UStaticMesh Mesh;
	public float LODSizeScale;
	public bool bUseStaticMeshLODs;
	public bool CastShadows;
	public bool DoCollisions;
	public byte MeshAlignment;
	public bool bOverrideMaterial;
	public bool bOverrideDefaultMotionBlurSettings;
	public bool bEnableMotionBlur;
	public FRawDistributionVector RollPitchYawRange;
	public byte AxisLockOption;
	public bool bCameraFacing;
	public byte CameraFacingUpAxisOption_DEPRECATED;
	public byte CameraFacingOption;
	public bool bApplyParticleRotationAsSpin;
	public bool bFaceCameraDirectionRatherThanPosition;
	public bool bCollisionsConsiderPartilceSize;
}
