#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public partial class UGenerateStaticMeshLODProcess : UObject {
// GenerateStaticMeshLODProcess
	public UStaticMesh SourceStaticMesh;
	public TSet<UTexture2D> AllDerivedTextures;
	public UTexture2D DerivedNormalMapTex;
	public UTexture2D DerivedMultiTextureBakeResult;
}
