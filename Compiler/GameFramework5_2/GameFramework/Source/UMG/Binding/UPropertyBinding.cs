#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Binding/PropertyBinding.h")]
public partial class UPropertyBinding : UObject {
// PropertyBinding
	public TWeakObjectPtr<UObject> SourceObject;
	public FDynamicPropertyPath SourcePath;
	public string DestinationProperty;
}
