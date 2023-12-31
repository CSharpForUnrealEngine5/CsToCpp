namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for Implicit Offsetting</summary>
[CppInclude("OffsetMeshTool.h")]
public partial class UImplicitOffsetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>How tightly we should constrain the constrained implicit offset to the explicit offset</summary>
	public float Smoothness;
	///<summary>If this is false, triangles will be reshaped to be more regular, which will distort UVs</summary>
	public bool bPreserveUVs;
}
