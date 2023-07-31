#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Turn static mesh data into Slate&#39;s simple vector art format.</summary>
[CppInclude("Slate/SlateVectorArtData.h")]
public partial class USlateVectorArtData : UObject {
	///<summary>The mesh data asset from which the vector art is sourced</summary>
	public UStaticMesh MeshAsset;
	///<summary>The material which we are using, or the material from with the MIC was constructed.</summary>
	public UMaterialInterface SourceMaterial;
	///<summary>See: GetVertexData()</summary>
	public TArray<FSlateMeshVertex> VertexData;
	///<summary>See: GetIndexData()</summary>
	public TArray<uint> IndexData;
	///<summary>See: GetMaterial()</summary>
	public UMaterialInterface Material;
	///<summary>ExtentMin</summary>
	public FVector2D ExtentMin;
	///<summary>ExtentMax</summary>
	public FVector2D ExtentMax;
}
