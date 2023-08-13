namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory to import USD files that gets called when we hit File -&gt; Import into level...</summary>
[CppInclude("USDStageImportFactory.h")]
public partial class UUsdStageImportFactory : USceneImportFactory {
	public static UClass StaticClass() {return default;}
	///<summary>ImportContext</summary>
	public FUsdStageImportContext ImportContext;
}
