namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for a directional filter. Allows for displacement to be applied only to vertices whose normals point in a given direction</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshDirectionalFilterProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the directional filter is active.</summary>
	public bool bEnableFilter;
	///<summary>Unit vector representing the direction to filter along.</summary>
	public FVector FilterDirection;
	///<summary>Scalar value determining how close to the filter direction the vertex normals must be in order to be displaced.</summary>
	public float FilterWidth;
}
