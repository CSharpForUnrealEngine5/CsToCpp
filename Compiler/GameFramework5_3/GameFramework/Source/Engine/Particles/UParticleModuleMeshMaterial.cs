namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Material/ParticleModuleMeshMaterial.h")]
public partial class UParticleModuleMeshMaterial : UParticleModuleMaterialBase {
	public static UClass StaticClass() {return default;}
	///<summary>The array of materials to apply to the mesh particles.</summary>
	public TArray<UMaterialInterface> MeshMaterials;
}
