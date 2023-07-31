#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
public partial class UOptimusDeformerInstanceSettings : UMeshDeformerInstanceSettings {
	///<summary>Stored weak pointer to a deformer. This is only required by the details customization for resolving binding class types.</summary>
	public TWeakObjectPtr<UOptimusDeformer> Deformer;
	///<summary>Array of binding descriptions. This is fixed and used by GetComponentBindings() to resolve final bindings for a given context.</summary>
	public TArray<FOptimusDeformerInstanceComponentBinding> Bindings;
}
