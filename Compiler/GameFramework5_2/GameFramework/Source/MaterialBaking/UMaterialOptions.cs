#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialOptions.h")]
///<summary>Options object to define what and how a material should be baked out</summary>
public partial class UMaterialOptions : UObject {
// MaterialOptions
	public TArray<FPropertyEntry> Properties;
	public FIntPoint TextureSize;
	public TArray<int> LODIndices;
	public bool bUseMeshData;
	public bool bUseSpecificUVIndex;
	public int TextureCoordinateIndex;
}
