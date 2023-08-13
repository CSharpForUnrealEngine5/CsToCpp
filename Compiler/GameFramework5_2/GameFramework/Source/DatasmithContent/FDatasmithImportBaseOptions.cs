namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithImportOptions.h")]
public partial struct FDatasmithImportBaseOptions {
	public EDatasmithImportScene SceneHandling;
	public bool bIncludeGeometry;
	public bool bIncludeMaterial;
	public bool bIncludeLight;
	public bool bIncludeCamera;
	public bool bIncludeAnimation;
	public FDatasmithAssetImportOptions AssetOptions;
	public FDatasmithStaticMeshImportOptions StaticMeshOptions;
}
