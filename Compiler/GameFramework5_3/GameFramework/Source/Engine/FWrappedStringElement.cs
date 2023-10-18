namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used by UUIString::WrapString to track information about each line that is generated as the result of wrapping.</summary>
[CppInclude("CanvasTypes.h")]
public partial struct FWrappedStringElement {
	public string Value;
	public FVector2D LineExtent;
}
