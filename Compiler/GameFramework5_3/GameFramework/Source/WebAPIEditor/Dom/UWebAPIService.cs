namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A service generally contains a sub-section of the API containing operations related to a particular subject.</summary>
[CppInclude("Dom/WebAPIService.h")]
public partial class UWebAPIService : UWebAPIModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Service.</summary>
	public FWebAPITypeNameVariant Name;
	///<summary>Can be disabled to skip generation of this Service and it&#39;s operations.</summary>
	public bool bGenerate;
	///<summary>Operations contained within the service.</summary>
	public TArray<UWebAPIOperation> Operations;
}
