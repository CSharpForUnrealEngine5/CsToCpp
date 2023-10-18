namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unique settings for the smoothing tool</summary>
[CppInclude("ClothPaintTools.h")]
public partial class UClothPaintTool_SmoothSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the smoothing effect</summary>
	public float Strength;
}
