#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Detail Map Baking Tool</summary>
[CppInclude("BakeMeshAttributeMapsTool.h")]
public partial class UBakeMeshAttributeMapsTool : UBakeMeshAttributeMapsToolBase {
	///<summary>need to update bResultValid if these are modified, so we don&#39;t publicly expose them.</summary>
	public UBakeInputMeshProperties InputMeshSettings;
	///<summary>Settings</summary>
	public UBakeMeshAttributeMapsToolProperties Settings;
	///<summary>ResultSettings</summary>
	public UBakeMeshAttributeMapsResultToolProperties ResultSettings;
}
