#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Material/ParticleModuleMeshMaterial.h")]
public partial class UParticleModuleMeshMaterial : UParticleModuleMaterialBase {
	public static UClass StaticClass() {return default;}
	///<summary>The array of materials to apply to the mesh particles.</summary>
	public TArray<UMaterialInterface> MeshMaterials;
}
