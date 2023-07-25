#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>Simple Mesh Displacement Tool</summary>
public partial class UDisplaceMeshTool : USingleSelectionMeshEditingTool {
// DisplaceMeshTool
	public UDisplaceMeshCommonProperties CommonProperties;
	public UDisplaceMeshDirectionalFilterProperties DirectionalFilterProperties;
	public UDisplaceMeshTextureMapProperties TextureMapProperties;
	public UDisplaceMeshPerlinNoiseProperties NoiseProperties;
	public UDisplaceMeshSineWaveProperties SineWaveProperties;
	public USelectiveTessellationProperties SelectiveTessellationProperties;
	public UCurveFloat ActiveContrastCurveTarget;
	public AInternalToolFrameworkActor PreviewMeshActor;
	public UDynamicMeshComponent DynamicMeshComponent;
}
