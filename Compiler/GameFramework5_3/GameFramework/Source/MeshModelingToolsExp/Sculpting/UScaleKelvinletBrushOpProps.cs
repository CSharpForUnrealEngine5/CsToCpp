namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/KelvinletBrushOp.h")]
public partial class UScaleKelvinletBrushOpProps : UBaseKelvinletBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
}
