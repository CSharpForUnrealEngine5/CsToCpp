#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoleFillTool.h")]
public partial class UHoleFillToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>FillType</summary>
	public EHoleFillOpFillType FillType;
	///<summary>Clean up triangles that have no neighbors</summary>
	public bool bRemoveIsolatedTriangles;
	///<summary>Identify and quickly fill single-triangle holes</summary>
	public bool bQuickFillSmallHoles;
}
