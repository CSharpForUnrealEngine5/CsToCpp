namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolOutputProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to modify the static mesh in place or create a new one.</summary>
	public EGenerateLODAssetOutputMode OutputMode;
	///<summary>Base name for newly-generated asset</summary>
	public string NewAssetName;
	///<summary>If the Asset doesn&#39;t already have a HiRes source, store the input mesh as the HiRes source</summary>
	public bool bSaveInputAsHiResSource;
	///<summary>Suffix to append to newly-generated Asset (Meshes, Textures, Materials, etc)</summary>
	public string GeneratedSuffix;
	///<summary>If false, then OutputMode will not be shown in DetailsView panels (otherwise no effect)</summary>
	public bool bShowOutputMode;
}
