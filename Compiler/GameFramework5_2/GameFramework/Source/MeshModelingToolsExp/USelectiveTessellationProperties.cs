#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>PropertySet for properties affecting the selective tessellation.</summary>
public partial class USelectiveTessellationProperties : UInteractiveToolPropertySet {
// SelectiveTessellationProperties
	public EDisplaceMeshToolTriangleSelectionType SelectionType;
	public string ActiveMaterial;
	public TArray<string> GetMaterialIDsFunc() { return default; }
	public TArray<string> MaterialIDList;
}
