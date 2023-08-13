namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FOV Scaling</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierFOVScaling : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Extra scalar applied on top of basic FOV scaling.</summary>
	public float FOVScale;
	///<summary>FOVScalingType</summary>
	public EFOVScalingType FOVScalingType;
}
