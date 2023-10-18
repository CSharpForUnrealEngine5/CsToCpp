namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/KelvinletBrushOp.h")]
public partial class UTwistKelvinletBrushOpProps : UBaseKelvinletBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Twisting strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
}
