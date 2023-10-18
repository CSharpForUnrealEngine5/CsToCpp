namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial struct FGeometryScriptRemoveHiddenTrianglesOptions {
	public EGeometryScriptRemoveHiddenTrianglesMethod Method;
	public int SamplesPerTriangle;
	public int ShrinkSelection;
	public float WindingIsoValue;
	public int RaysPerSample;
	public float NormalOffset;
	public bool bCompactResult;
}
