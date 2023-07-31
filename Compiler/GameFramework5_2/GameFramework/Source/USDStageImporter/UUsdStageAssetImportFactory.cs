#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory to import USD files that gets called when we hit Import in the Content Browser, as well as during reimport</summary>
[CppInclude("USDStageAssetImportFactory.h")]
public partial class UUsdStageAssetImportFactory : UFactory {
	///<summary>ImportContext</summary>
	public FUsdStageImportContext ImportContext;
}
