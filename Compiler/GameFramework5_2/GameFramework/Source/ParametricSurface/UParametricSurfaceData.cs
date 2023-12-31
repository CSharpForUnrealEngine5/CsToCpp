namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricSurfaceData.h")]
public partial class UParametricSurfaceData : UDatasmithAdditionalData {
	public static UClass StaticClass() {return default;}
	///<summary>SceneParameters</summary>
	public FParametricSceneParameters SceneParameters;
	///<summary>MeshParameters</summary>
	public FParametricMeshParameters MeshParameters;
	///<summary>LastTessellationOptions</summary>
	public FDatasmithTessellationOptions LastTessellationOptions;
	///<summary>RawData_DEPRECATED</summary>
	public TArray<byte> RawData_DEPRECATED;
}
