namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPatchTool.h")]
public partial class UAddPatchToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Width of Shape</summary>
	public float Width;
	///<summary>Rotation around up axis</summary>
	public float Rotation;
	///<summary>Subdivisions</summary>
	public int Subdivisions;
	///<summary>Rotation around up axis</summary>
	public float Shift;
}
