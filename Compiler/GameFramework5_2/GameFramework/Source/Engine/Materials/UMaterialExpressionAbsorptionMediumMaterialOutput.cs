namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for setting absorption properties of solid refractive glass (for the Path Tracer Only).</summary>
[CppInclude("Materials/MaterialExpressionAbsorptionMediumMaterialOutput.h")]
public partial class UMaterialExpressionAbsorptionMediumMaterialOutput : UMaterialExpressionCustomOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Input for the transmittance color seen after travelling a distance of 100 units into the object. Valid range is [0,1].</summary>
	public FExpressionInput TransmittanceColor;
}
