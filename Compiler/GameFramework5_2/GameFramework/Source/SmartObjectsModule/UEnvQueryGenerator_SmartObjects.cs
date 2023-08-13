namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fetches Smart Object slots within QueryBoxExtent from locations given by QueryOriginContext, that match SmartObjectRequestFilter</summary>
[CppInclude("EnvQueryGenerator_SmartObjects.h")]
public partial class UEnvQueryGenerator_SmartObjects : UEnvQueryGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>The context indicating the locations to be used as query origins</summary>
	public UClass QueryOriginContext;
	///<summary>If set will be used to filter gathered results</summary>
	public FSmartObjectRequestFilter SmartObjectRequestFilter;
	///<summary>Combined with generator&#39;s origin(s) (as indicated by QueryOriginContext) determines query&#39;s volume</summary>
	public FVector QueryBoxExtent;
	///<summary>Determines whether only currently claimable slots are allowed</summary>
	public bool bOnlyClaimable;
}
