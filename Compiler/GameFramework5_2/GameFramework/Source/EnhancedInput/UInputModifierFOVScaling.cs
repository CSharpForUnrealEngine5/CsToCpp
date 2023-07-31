#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FOV Scaling</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierFOVScaling : UInputModifier {
	///<summary>Extra scalar applied on top of basic FOV scaling.</summary>
	public float FOVScale;
	///<summary>FOVScalingType</summary>
	public EFOVScalingType FOVScalingType;
}
