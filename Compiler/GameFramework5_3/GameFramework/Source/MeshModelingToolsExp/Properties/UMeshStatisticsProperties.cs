namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshStatisticsProperties.h")]
public partial class UMeshStatisticsProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh</summary>
	public string Mesh;
	///<summary>UV</summary>
	public string UV;
	///<summary>Attributes</summary>
	public string Attributes;
}
