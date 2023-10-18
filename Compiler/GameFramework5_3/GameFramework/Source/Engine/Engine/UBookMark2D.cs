namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple class to store 2D camera information.</summary>
[CppInclude("Engine/BookMark2D.h")]
public partial class UBookMark2D : UBookmarkBase {
	public static UClass StaticClass() {return default;}
	///<summary>Zoom of the camera</summary>
	public float Zoom2D;
	///<summary>Location of the camera</summary>
	public FIntPoint Location;
}
