#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>N-to-1 Detail Map Baking Tool</summary>
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>need to update bResultValid if these are modified, so we don&#39;t publicly expose them.</summary>
	public UBakeMultiMeshAttributeMapsToolProperties Settings;
	///<summary>InputMeshSettings</summary>
	public UBakeMultiMeshInputToolProperties InputMeshSettings;
	///<summary>ResultSettings</summary>
	public UBakeMeshAttributeMapsResultToolProperties ResultSettings;
}
