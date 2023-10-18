namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithFBXSceneImportData : UDatasmithSceneImportData {
	public static UClass StaticClass() {return default;}
	///<summary>bGenerateLightmapUVs</summary>
	public bool bGenerateLightmapUVs;
	///<summary>TexturesDir</summary>
	public string TexturesDir;
	///<summary>Corresponds to a EDatasmithFBXIntermediateSerializationType</summary>
	public byte IntermediateSerialization;
	///<summary>bColorizeMaterials</summary>
	public bool bColorizeMaterials;
}
