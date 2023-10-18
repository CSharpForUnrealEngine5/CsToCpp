namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairBendConstraint {
	public bool SolveBend;
	public bool ProjectBend;
	public float BendDamping;
	public float BendStiffness;
	public FRuntimeFloatCurve BendScale;
}
