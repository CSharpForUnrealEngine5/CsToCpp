namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory to import USD files that gets called when we hit Import in the Content Browser, as well as during reimport</summary>
[CppInclude("USDStageAssetImportFactory.h")]
public partial class UUsdStageAssetImportFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>ImportContext</summary>
	public FUsdStageImportContext ImportContext;
}
