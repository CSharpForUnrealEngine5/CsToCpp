#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithImportOptions.h")]
public partial struct FDatasmithImportBaseOptions {
// DatasmithImportBaseOptions
	public EDatasmithImportScene SceneHandling;
	public bool bIncludeGeometry;
	public bool bIncludeMaterial;
	public bool bIncludeLight;
	public bool bIncludeCamera;
	public bool bIncludeAnimation;
	public FDatasmithAssetImportOptions AssetOptions;
	public FDatasmithStaticMeshImportOptions StaticMeshOptions;
}
