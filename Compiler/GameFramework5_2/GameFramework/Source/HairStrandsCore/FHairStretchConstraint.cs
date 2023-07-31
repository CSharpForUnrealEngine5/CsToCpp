#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairStretchConstraint {
	public bool SolveStretch;
	public bool ProjectStretch;
	public float StretchDamping;
	public float StretchStiffness;
	public FRuntimeFloatCurve StretchScale;
}
