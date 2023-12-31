namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportVertexColorOptions.h")]
public partial class UImportVertexColorOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Texture Coordinate Channel to use for Sampling the Texture</summary>
	public int UVIndex;
	///<summary>LOD Index to import the Vertex Colors to</summary>
	public int LODIndex;
	///<summary>Red Texture Channel</summary>
	public bool bRed;
	///<summary>Blue Texture Channel</summary>
	public bool bBlue;
	///<summary>Green Texture Channel</summary>
	public bool bGreen;
	///<summary>Alpha Texture Channel</summary>
	public bool bAlpha;
	///<summary>Whether or not to import the Vertex Colors to Mesh Component instance or the underlying Static Mesh</summary>
	public bool bImportToInstance;
	///<summary>bCanImportToInstance</summary>
	public bool bCanImportToInstance;
}
