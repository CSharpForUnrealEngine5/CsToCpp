#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory to import USD files that gets called when we hit File -&gt; Import into level...</summary>
[CppInclude("USDStageImportFactory.h")]
public partial class UUsdStageImportFactory : USceneImportFactory {
	///<summary>ImportContext</summary>
	public FUsdStageImportContext ImportContext;
}
