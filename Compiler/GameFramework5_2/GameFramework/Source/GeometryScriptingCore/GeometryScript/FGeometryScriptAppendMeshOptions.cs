namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control how details like mesh attributes are handled when one mesh is appended to another</summary>
[CppInclude("GeometryScript/MeshBasicEditFunctions.h")]
public partial struct FGeometryScriptAppendMeshOptions {
	public EGeometryScriptCombineAttributesMode CombineMode;
}
