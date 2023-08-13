namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UENUM()</summary>
[CppInclude("DatasmithC4DImportOptions.h")]
public partial class UDatasmithC4DImportOptions : UDatasmithOptionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Import Mesh With No Vertex, false by default</summary>
	public bool bImportEmptyMesh;
	///<summary>Remove empty actors that have only one child, false by default</summary>
	public bool bOptimizeEmptySingleChildActors;
	///<summary>Ignore the normals provided by Melange and let Datasmith generate them</summary>
	public bool bAlwaysGenerateNormals;
	///<summary>Scale all position and vertices by this value.</summary>
	public float ScaleVertices;
	///<summary>Export the imported scene as a .datasmith file, next to the .c4d file.</summary>
	public bool bExportToUDatasmith;
}
