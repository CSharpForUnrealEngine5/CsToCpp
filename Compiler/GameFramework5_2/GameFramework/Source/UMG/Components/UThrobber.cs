#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Throbber.h")]
///<summary>A Throbber widget that shows several zooming circles in a row.</summary>
public partial class UThrobber : UWidget {
// Throbber
	public int NumberOfPieces;
	public bool bAnimateHorizontally;
	public bool bAnimateVertically;
	public bool bAnimateOpacity;
	public FSlateBrush Image;
	public  void SetNumberOfPieces(int InNumberOfPieces) {}
	public  void SetAnimateHorizontally(bool bInAnimateHorizontally) {}
	public  void SetAnimateVertically(bool bInAnimateVertically) {}
	public  void SetAnimateOpacity(bool bInAnimateOpacity) {}
}
