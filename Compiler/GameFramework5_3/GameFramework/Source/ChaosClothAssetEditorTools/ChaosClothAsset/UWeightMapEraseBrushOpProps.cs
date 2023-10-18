namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Erase Brush</summary>
[CppInclude("ChaosClothAsset/ClothWeightMapPaintBrushOps.h")]
public partial class UWeightMapEraseBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute to set as Erased value</summary>
	public double AttributeValue;
}
