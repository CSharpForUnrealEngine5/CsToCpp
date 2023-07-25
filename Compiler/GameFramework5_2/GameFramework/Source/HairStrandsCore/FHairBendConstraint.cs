#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairBendConstraint {
// HairBendConstraint
	public bool SolveBend;
	public bool ProjectBend;
	public float BendDamping;
	public float BendStiffness;
	public FRuntimeFloatCurve BendScale;
}
