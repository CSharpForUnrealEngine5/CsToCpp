#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
public partial class UOptimusDeformerInstanceSettings : UMeshDeformerInstanceSettings {
// OptimusDeformerInstanceSettings
	public TWeakObjectPtr<UOptimusDeformer> Deformer;
	public TArray<FOptimusDeformerInstanceComponentBinding> Bindings;
}
