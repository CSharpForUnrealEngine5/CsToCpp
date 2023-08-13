namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Throbber widget that shows several zooming circles in a row.</summary>
[CppInclude("Components/Throbber.h")]
public partial class UThrobber : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>How many pieces there are</summary>
	public int NumberOfPieces;
	///<summary>Should the pieces animate horizontally?</summary>
	public bool bAnimateHorizontally;
	///<summary>Should the pieces animate vertically?</summary>
	public bool bAnimateVertically;
	///<summary>Should the pieces animate their opacity?</summary>
	public bool bAnimateOpacity;
	///<summary>The animated pieces.</summary>
	public FSlateBrush Image;
	///<summary>Sets how many pieces there are</summary>
	public void SetNumberOfPieces(int InNumberOfPieces) {}
	///<summary>Sets whether the pieces animate horizontally.</summary>
	public void SetAnimateHorizontally(bool bInAnimateHorizontally) {}
	///<summary>Sets whether the pieces animate vertically.</summary>
	public void SetAnimateVertically(bool bInAnimateVertically) {}
	///<summary>Sets whether the pieces animate their opacity.</summary>
	public void SetAnimateOpacity(bool bInAnimateOpacity) {}
}
