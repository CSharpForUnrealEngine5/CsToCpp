#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIService.h")]
///<summary>A service generally contains a sub-section of the API containing operations related to a particular subject.</summary>
public partial class UWebAPIService : UWebAPIModelBase {
// WebAPIService
	public FWebAPITypeNameVariant Name;
	public bool bGenerate;
	public TArray<UWebAPIOperation> Operations;
}
