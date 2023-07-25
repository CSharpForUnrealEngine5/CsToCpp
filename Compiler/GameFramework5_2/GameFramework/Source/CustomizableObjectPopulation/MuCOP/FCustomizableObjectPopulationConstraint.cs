#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulationConstraint.h")]
public partial struct FCustomizableObjectPopulationConstraint {
// CustomizableObjectPopulationConstraint
	public EPopulationConstraintType Type;
	public int ConstraintWeight;
	public int TrueWeight;
	public int FalseWeight;
	public string DiscreteValue;
	public FLinearColor DiscreteColor;
	public TArray<string> Allowlist;
	public TArray<string> Blocklist;
	public TArray<FConstraintRanges> Ranges;
	public UCurveBase Curve;
	public ECurveColor CurveColor;
}
