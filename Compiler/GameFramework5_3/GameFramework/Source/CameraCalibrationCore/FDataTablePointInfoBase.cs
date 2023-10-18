namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for point info wrapper which holds focus and zoom</summary>
[CppInclude("LensData.h")]
public partial struct FDataTablePointInfoBase {
	public float Focus;
	public float Zoom;
}
