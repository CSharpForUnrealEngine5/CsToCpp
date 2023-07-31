#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple class to store 2D camera information.</summary>
[CppInclude("Engine/BookMark2D.h")]
public partial class UBookMark2D : UBookmarkBase {
	///<summary>Zoom of the camera</summary>
	public float Zoom2D;
	///<summary>Location of the camera</summary>
	public FIntPoint Location;
}
