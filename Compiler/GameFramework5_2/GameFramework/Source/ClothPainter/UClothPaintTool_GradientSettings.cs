#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unique settings for the Gradient tool</summary>
[CppInclude("ClothPaintTools.h")]
public partial class UClothPaintTool_GradientSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Value of the gradient at the start points</summary>
	public float GradientStartValue;
	///<summary>Value of the gradient at the end points</summary>
	public float GradientEndValue;
	///<summary>Enables the painting of selected points using a brush rather than just a point</summary>
	public bool bUseRegularBrush;
}
