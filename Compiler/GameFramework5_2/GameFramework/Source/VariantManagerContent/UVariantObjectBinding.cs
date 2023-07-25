#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantObjectBinding.h")]
public partial class UVariantObjectBinding : UObject {
// VariantObjectBinding
	public string CachedActorLabel;
	public FSoftObjectPath ObjectPtr;
	public TLazyObjectPtr<UObject> LazyObjectPtr;
	public TArray<UPropertyValue> CapturedProperties;
	public TArray<FFunctionCaller> FunctionCallers;
}
