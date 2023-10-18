namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectLayout.h")]
public partial class UCustomizableObjectLayout : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Blocks</summary>
	public TArray<FCustomizableObjectLayoutBlock> Blocks;
	///<summary>Mesh</summary>
	public UObject Mesh;
	///<summary>LOD</summary>
	public int LOD;
	///<summary>Material</summary>
	public int Material;
	///<summary>UVChannel</summary>
	public int UVChannel;
	///<summary>GridSize</summary>
	public FIntPoint GridSize;
	///<summary>Used with the fixed layout strategy.</summary>
	public FIntPoint MaxGridSize;
	///<summary>PackingStrategy</summary>
	public ECustomizableObjectTextureLayoutPackingStrategy PackingStrategy;
	///<summary>LayoutName</summary>
	public string LayoutName;
	///<summary>If true, vertex warning messages will be ignored</summary>
	public bool bIgnoreUnassignedVertexWarning;
	///<summary>First LOD from which unassigned vertices warning will be ignored</summary>
	public int FirstLODToIgnore;
	///<summary>BlockReductionMethod</summary>
	public ECustomizableObjectLayoutBlockReductionMethod BlockReductionMethod;
}
