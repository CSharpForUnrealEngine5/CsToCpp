#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeVertexTool.h")]
public partial class UBakeMeshAttributeVertexToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The bake output mode</summary>
	public EBakeVertexOutput OutputMode;
	///<summary>The bake output type to generate</summary>
	public int OutputType;
	///<summary>The bake output type to generate in the Red channel</summary>
	public int OutputTypeR;
	///<summary>The bake output type to generate in the Green channel</summary>
	public int OutputTypeG;
	///<summary>The bake output type to generate in the Blue channel</summary>
	public int OutputTypeB;
	///<summary>The bake output type to generate in the Alpha channel</summary>
	public int OutputTypeA;
	///<summary>The vertex color channel to preview</summary>
	public EBakeVertexChannel PreviewMode;
	///<summary>If true, compute a separate vertex color for each unique normal on a vertex</summary>
	public bool bSplitAtNormalSeams;
	///<summary>If true, Compute a separate vertex color for each unique UV on a vertex.</summary>
	public bool bSplitAtUVSeams;
}
