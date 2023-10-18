namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paint Brush</summary>
[CppInclude("ChaosClothAsset/ClothWeightMapPaintBrushOps.h")]
public partial class UWeightMapPaintBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>The Attribute that will be assigned to triangles within the brush region</summary>
	public double AttributeValue;
	///<summary>Strength of the Brush</summary>
	public float Strength;
}
