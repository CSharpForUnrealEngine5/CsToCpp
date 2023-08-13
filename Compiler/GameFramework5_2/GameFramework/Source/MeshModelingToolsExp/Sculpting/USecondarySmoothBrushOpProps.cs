namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSmoothingBrushOps.h")]
public partial class USecondarySmoothBrushOpProps : UBaseSmoothBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>If true, try to preserve the shape of the UV/3D mapping. This will limit Smoothing and Remeshing in some cases.</summary>
	public bool bPreserveUVFlow;
}
