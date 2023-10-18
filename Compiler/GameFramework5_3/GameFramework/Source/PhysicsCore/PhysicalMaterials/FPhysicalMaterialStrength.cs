namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines the directional strengths of a physical material in term of force per surface area</summary>
[CppInclude("PhysicalMaterials/PhysicalMaterial.h")]
public partial struct FPhysicalMaterialStrength {
	public float TensileStrength;
	public float CompressionStrength;
	public float ShearStrength;
}
