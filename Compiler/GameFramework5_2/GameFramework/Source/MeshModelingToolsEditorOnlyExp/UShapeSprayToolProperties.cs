#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings UObject for UShapeSprayTool.</summary>
[CppInclude("ShapeSprayTool.h")]
public partial class UShapeSprayToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Color</summary>
	public FLinearColor Color;
	///<summary>bRandomColor</summary>
	public bool bRandomColor;
	///<summary>DropSpeed</summary>
	public float DropSpeed;
	///<summary>ObjectSize</summary>
	public float ObjectSize;
	///<summary>NumSplats</summary>
	public int NumSplats;
	///<summary>Material</summary>
	public UMaterialInterface Material;
}
