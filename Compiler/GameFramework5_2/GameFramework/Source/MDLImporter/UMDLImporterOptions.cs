#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MDLImporterOptions.h")]
public partial class UMDLImporterOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Resolution for baking procedural textures.</summary>
	public uint BakingResolution;
	///<summary>Samples used for baking procedural textures.</summary>
	public uint BakingSamples;
	///<summary>Path to look for resources: textures, light profiles and other.</summary>
	public FDirectoryPath ResourcesDir;
	///<summary>Path to look for extra MDL modules.</summary>
	public FDirectoryPath ModulesDir;
	///<summary>The conversion ratio between meters and scene units for materials.</summary>
	public float MetersPerSceneUnit;
	///<summary>Always bakes the maps to textures instead of using material nodes.</summary>
	public bool bForceBaking;
}
