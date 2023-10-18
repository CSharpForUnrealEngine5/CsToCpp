namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UBrushRemeshProperties : URemeshProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Toggle remeshing on/off</summary>
	public bool bEnableRemeshing;
	///<summary>Desired size of triangles after Remeshing, relative to average initial triangle size. Larger value results in larger triangles.</summary>
	public int TriangleSize;
	///<summary>Control the amount of simplification during sculpting. Higher values will avoid wiping out fine details on the mesh.</summary>
	public int PreserveDetail;
	///<summary>Iterations</summary>
	public int Iterations;
}
