#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Used to determine how we should handle mouse wheel input events when someone scrolls.</summary>
public enum EConsumeMouseWheel {
	WhenScrollingPossible=0,
	Always=1,
	Never=2,
}
