namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshAnalysisProperties.h")]
public partial class UMeshAnalysisProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>In meters squared</summary>
	public string SurfaceArea;
	///<summary>In cubic meters</summary>
	public string Volume;
}
