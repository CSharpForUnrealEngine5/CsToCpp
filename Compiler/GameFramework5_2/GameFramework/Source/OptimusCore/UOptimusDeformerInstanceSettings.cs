namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
public partial class UOptimusDeformerInstanceSettings : UMeshDeformerInstanceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Stored weak pointer to a deformer. This is only required by the details customization for resolving binding class types.</summary>
	public TWeakObjectPtr<UOptimusDeformer> Deformer;
	///<summary>Array of binding descriptions. This is fixed and used by GetComponentBindings() to resolve final bindings for a given context.</summary>
	public TArray<FOptimusDeformerInstanceComponentBinding> Bindings;
}
