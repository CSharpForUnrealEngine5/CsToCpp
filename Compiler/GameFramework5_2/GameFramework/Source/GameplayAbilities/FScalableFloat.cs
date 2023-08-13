namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic numerical value in the form Value * Curve[Level]</summary>
[CppInclude("ScalableFloat.h")]
public partial struct FScalableFloat {
	public float Value;
	public FCurveTableRowHandle Curve;
	public FDataRegistryType RegistryType;
}
