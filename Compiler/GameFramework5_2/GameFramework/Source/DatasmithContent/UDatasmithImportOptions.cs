namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithImportOptions.h")]
public partial class UDatasmithImportOptions : UDatasmithOptionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies where to search for assets</summary>
	public EDatasmithImportSearchPackagePolicy SearchPackagePolicy;
	///<summary>Specifies what to do when material conflicts</summary>
	public EDatasmithImportAssetConflictPolicy MaterialConflictPolicy;
	///<summary>Specifies what to do when texture conflicts</summary>
	public EDatasmithImportAssetConflictPolicy TextureConflictPolicy;
	///<summary>Specifies what to do when actor conflicts</summary>
	public EDatasmithImportActorPolicy StaticMeshActorImportPolicy;
	///<summary>Specifies what to do when light conflicts</summary>
	public EDatasmithImportActorPolicy LightImportPolicy;
	///<summary>Specifies what to do when material conflicts</summary>
	public EDatasmithImportActorPolicy CameraImportPolicy;
	///<summary>Specifies what to do when actor conflicts</summary>
	public EDatasmithImportActorPolicy OtherActorImportPolicy;
	///<summary>Specifies what to do when material conflicts</summary>
	public EDatasmithImportMaterialQuality MaterialQuality;
	///<summary>Not displayed. Kept for future use</summary>
	public FDatasmithImportBaseOptions BaseOptions;
	///<summary>Options specific to the reimport process</summary>
	public FDatasmithReimportOptions ReimportOptions;
	///<summary>Name of the imported file without its path</summary>
	public string FileName;
	///<summary>Full path of the imported file</summary>
	public string FilePath;
	///<summary>SourceUri</summary>
	public string SourceUri;
}
