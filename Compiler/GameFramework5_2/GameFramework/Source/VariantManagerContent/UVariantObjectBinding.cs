#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantObjectBinding.h")]
public partial class UVariantObjectBinding : UObject {
	///<summary>Whenever we resolve, we cache the actor label here so that if we can&#39;t</summary>
	public string CachedActorLabel;
	///<summary>ObjectPtr</summary>
	public FSoftObjectPath ObjectPtr;
	///<summary>LazyObjectPtr</summary>
	public TLazyObjectPtr<UObject> LazyObjectPtr;
	///<summary>CapturedProperties</summary>
	public TArray<UPropertyValue> CapturedProperties;
	///<summary>FunctionCallers</summary>
	public TArray<FFunctionCaller> FunctionCallers;
}
