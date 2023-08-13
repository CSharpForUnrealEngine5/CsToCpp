namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for a constraint setup, these can be horizontal, vertical, shear and bend.</summary>
[CppInclude("ClothConfigNv.h")]
public partial struct FClothConstraintSetupNv {
	public float Stiffness;
	public float StiffnessMultiplier;
	public float StretchLimit;
	public float CompressionLimit;
}
