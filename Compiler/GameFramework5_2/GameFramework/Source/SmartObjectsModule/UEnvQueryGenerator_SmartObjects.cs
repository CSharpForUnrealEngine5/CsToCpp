#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvQueryGenerator_SmartObjects.h")]
///<summary>Fetches Smart Object slots within QueryBoxExtent from locations given by QueryOriginContext, that match SmartObjectRequestFilter</summary>
public partial class UEnvQueryGenerator_SmartObjects : UEnvQueryGenerator {
// EnvQueryGenerator_SmartObjects
	public UClass QueryOriginContext;
	public FSmartObjectRequestFilter SmartObjectRequestFilter;
	public FVector QueryBoxExtent;
	public bool bOnlyClaimable;
}
