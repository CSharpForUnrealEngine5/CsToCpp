#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
