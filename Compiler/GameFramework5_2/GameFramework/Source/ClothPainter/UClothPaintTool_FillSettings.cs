#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unique settings for the fill tool</summary>
[CppInclude("ClothPaintTools.h")]
public partial class UClothPaintTool_FillSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Threshold for fill operation, will keep filling until sampled verts aren&#39;t within this range of the original vertex</summary>
	public float Threshold;
	///<summary>The value to fill all selected verts to</summary>
	public float FillValue;
}
