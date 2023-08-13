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
