namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationSkelVertSurface.h")]
public partial class UParticleModuleLocationSkelVertSurface : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the module uses Verts or Surfaces for locations.</summary>
	public ELocationSkelVertSurfaceSource SourceType;
	///<summary>An offset to apply to each vert/surface</summary>
	public FVector UniversalOffset;
	///<summary>If true, update the particle locations each frame with that of the vert/surface</summary>
	public bool bUpdatePositionEachFrame;
	///<summary>If true, rotate mesh emitter meshes to orient w/ the vert/surface</summary>
	public bool bOrientMeshEmitters;
	///<summary>If true, particles inherit the associated bone velocity when spawned</summary>
	public bool bInheritBoneVelocity;
	///<summary>A scale on how much of the bone&#39;s velocity a particle will inherit.</summary>
	public float InheritVelocityScale;
	///<summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
	public FName SkelMeshActorParamName;
	///<summary>The name of the skeletal mesh to use in the editor</summary>
	public USkeletalMesh EditorSkelMesh;
	///<summary>This module will only spawn from verts or surfaces associated with the bones in this list</summary>
	public TArray<FName> ValidAssociatedBones;
	///<summary>When true use the RestrictToNormal and NormalTolerance values to check surface normals</summary>
	public bool bEnforceNormalCheck;
	///<summary>Use this normal to restrict spawning locations</summary>
	public FVector NormalToCompare;
	///<summary>Normal tolerance.  0 degrees means it must be an exact match, 180 degrees means it can be any angle.</summary>
	public float NormalCheckToleranceDegrees;
	///<summary>Normal tolerance.  Value between 1.0 and -1.0 with 1.0 being exact match, 0.0 being everything up to</summary>
	public float NormalCheckTolerance;
	///<summary>Array of material indices that are valid materials to spawn from.</summary>
	public TArray<int> ValidMaterialIndices;
	///<summary>If true, particles inherit the associated vertex color on spawn. This feature is not supported for GPU particles.</summary>
	public bool bInheritVertexColor;
	///<summary>If true, particles inherit the associated UV data on spawn. Accessed through dynamic parameter module X and Y, must be a &quot;Spawn Time Only&quot; parameter on &quot;AutoSet&quot; mode. This feature is not supported for GPU particles.</summary>
	public bool bInheritUV;
	///<summary>UV channel to inherit from the spawn mesh, internally clamped to those available.</summary>
	public uint InheritUVChannel;
}
