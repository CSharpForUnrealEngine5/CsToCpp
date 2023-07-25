#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Slate/SlateVectorArtData.h")]
///<summary>Turn static mesh data into Slate's simple vector art format.</summary>
public partial class USlateVectorArtData : UObject {
// SlateVectorArtData
	public UStaticMesh MeshAsset;
	public UMaterialInterface SourceMaterial;
	public TArray<FSlateMeshVertex> VertexData;
	public TArray<uint> IndexData;
	public UMaterialInterface Material;
	public FVector2D ExtentMin;
	public FVector2D ExtentMax;
}
