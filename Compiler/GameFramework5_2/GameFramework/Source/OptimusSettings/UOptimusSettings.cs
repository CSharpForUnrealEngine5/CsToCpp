#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusSettings.h")]
public partial class UOptimusSettings : UDeveloperSettings {
// OptimusSettings
	public EOptimusDefaultDeformerMode DefaultMode;
	public TSoftObjectPtr<UMeshDeformer> DefaultDeformer;
	public TSoftObjectPtr<UMeshDeformer> DefaultRecomputeTangentDeformer;
}
