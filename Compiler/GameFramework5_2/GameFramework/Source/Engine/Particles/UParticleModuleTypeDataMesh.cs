#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataMesh.h")]
public partial class UParticleModuleTypeDataMesh : UParticleModuleTypeDataBase {
	///<summary>The static mesh to render at the particle positions</summary>
	public UStaticMesh Mesh;
	///<summary>use the static mesh&#39;s LOD setup and switch LODs based on largest particle&#39;s screen size</summary>
	public float LODSizeScale;
	///<summary>use the static mesh&#39;s LOD setup and switch LODs based on largest particle&#39;s screen size</summary>
	public bool bUseStaticMeshLODs;
	///<summary>If true, has the meshes cast shadows</summary>
	public bool CastShadows;
	///<summary>UNUSED (the collision module dictates doing collisions)</summary>
	public bool DoCollisions;
	///<summary>The alignment to use on the meshes emitted.</summary>
	public EMeshScreenAlignment MeshAlignment;
	///<summary>If true, use the emitter material when rendering rather than the one applied</summary>
	public bool bOverrideMaterial;
	///<summary>bOverrideDefaultMotionBlurSettings</summary>
	public bool bOverrideDefaultMotionBlurSettings;
	///<summary>bEnableMotionBlur</summary>
	public bool bEnableMotionBlur;
	///<summary>The &#39;pre&#39; rotation pitch (in degrees) to apply to the static mesh used.</summary>
	public FRawDistributionVector RollPitchYawRange;
	///<summary>The axis to lock the mesh on. This overrides TypeSpecific mesh alignment as well as the LockAxis module.</summary>
	public EParticleAxisLock AxisLockOption;
	///<summary>If true, then point the X-axis of the mesh towards the camera.</summary>
	public bool bCameraFacing;
	///<summary>The axis of the mesh to point up when camera facing the X-axis.</summary>
	public EMeshCameraFacingUpAxis CameraFacingUpAxisOption_DEPRECATED;
	///<summary>The camera facing option to use:</summary>
	public EMeshCameraFacingOptions CameraFacingOption;
	///<summary>If true, apply &#39;sprite&#39; particle rotation about the orientation axis (direction mesh is pointing).</summary>
	public bool bApplyParticleRotationAsSpin;
	///<summary>If true, all camera facing options will point the mesh against the camera&#39;s view direction rather than pointing at the cameras location.</summary>
	public bool bFaceCameraDirectionRatherThanPosition;
	///<summary>If true, all collisions for mesh particle on this emitter will take the particle size into account.</summary>
	public bool bCollisionsConsiderPartilceSize;
}
