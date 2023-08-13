namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PropertySet for properties affecting the selective tessellation.</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class USelectiveTessellationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Optionally, restrict tessellation to a subset of the triangles.</summary>
	public EDisplaceMeshToolTriangleSelectionType SelectionType;
	///<summary>Name of the selected material.</summary>
	public string ActiveMaterial;
	///<summary>GetMaterialIDsFunc</summary>
	public TArray<string> GetMaterialIDsFunc() { return default; }
	///<summary>MaterialIDList</summary>
	public TArray<string> MaterialIDList;
}
