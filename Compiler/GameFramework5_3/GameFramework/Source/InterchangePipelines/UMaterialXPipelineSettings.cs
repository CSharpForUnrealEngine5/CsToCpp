namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMaterialXPipeline.h")]
public partial class UMaterialXPipelineSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PredefinedSurfaceShaders</summary>
	public TMap<EInterchangeMaterialXShaders,FSoftObjectPath> PredefinedSurfaceShaders;
}
