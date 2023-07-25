#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricSurfaceData.h")]
public partial class UParametricSurfaceData : UDatasmithAdditionalData {
// ParametricSurfaceData
	public FParametricSceneParameters SceneParameters;
	public FParametricMeshParameters MeshParameters;
	public FDatasmithTessellationOptions LastTessellationOptions;
	public TArray<byte> RawData_DEPRECATED;
}
