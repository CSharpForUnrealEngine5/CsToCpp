namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unique settings for the Brush tool</summary>
[CppInclude("ClothPaintTools.h")]
public partial class UClothPaintTool_BrushSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Value to paint onto the mesh for this parameter</summary>
	public float PaintValue;
}
