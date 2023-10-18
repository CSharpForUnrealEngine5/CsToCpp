namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/KelvinletBrushOp.h")]
public partial class USharpPullKelvinletBrushOpProps : UBaseKelvinletBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>Depth of Brush into surface along view ray</summary>
	public float Depth;
}
