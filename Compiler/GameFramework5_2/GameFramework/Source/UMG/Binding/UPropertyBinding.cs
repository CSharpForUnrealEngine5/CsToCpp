#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Binding/PropertyBinding.h")]
public partial class UPropertyBinding : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The source object to use as the initial container to resolve the Source Property Path on.</summary>
	public TWeakObjectPtr<UObject> SourceObject;
	///<summary>The property path to trace to resolve this binding on the Source Object</summary>
	public FDynamicPropertyPath SourcePath;
	///<summary>Used to determine if a binding already exists on the object and if this binding can be safely removed.</summary>
	public string DestinationProperty;
}
