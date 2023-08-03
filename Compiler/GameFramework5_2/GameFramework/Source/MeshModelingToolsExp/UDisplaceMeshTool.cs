#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Displacement Tool</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Shared properties for all displacement modes.</summary>
	public UDisplaceMeshCommonProperties CommonProperties;
	///<summary>Properties defining the directional filter.</summary>
	public UDisplaceMeshDirectionalFilterProperties DirectionalFilterProperties;
	///<summary>Properties defining the texture map</summary>
	public UDisplaceMeshTextureMapProperties TextureMapProperties;
	///<summary>Multi-layer Perlin noise frequencies and intensities</summary>
	public UDisplaceMeshPerlinNoiseProperties NoiseProperties;
	///<summary>Sine wave parameters and direction of displacement</summary>
	public UDisplaceMeshSineWaveProperties SineWaveProperties;
	///<summary>Selective tessellation properties</summary>
	public USelectiveTessellationProperties SelectiveTessellationProperties;
	///<summary>Contrast Curve we are actively listening to</summary>
	public UCurveFloat ActiveContrastCurveTarget;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
}
