#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options object to define what and how a material should be baked out</summary>
[CppInclude("MaterialOptions.h")]
public partial class UMaterialOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Properties which are supposed to be baked out for the material(s)</summary>
	public TArray<FPropertyEntry> Properties;
	///<summary>Size of the final texture(s) containing the baked out property data</summary>
	public FIntPoint TextureSize;
	///<summary>LOD indices for which the materials should be baked out</summary>
	public TArray<int> LODIndices;
	///<summary>Determines whether to not allow usage of the source mesh data while baking out material properties</summary>
	public bool bUseMeshData;
	///<summary>Flag whether or not the value of TextureCoordinateIndex should be used while baking out material properties</summary>
	public bool bUseSpecificUVIndex;
	///<summary>Specific texture coordinate which should be used to while baking out material properties as the positions stream</summary>
	public int TextureCoordinateIndex;
}
