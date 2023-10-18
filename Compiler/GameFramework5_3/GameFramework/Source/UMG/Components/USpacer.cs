namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A spacer widget; it does not have a visual representation, and just provides padding between other widgets.</summary>
[CppInclude("Components/Spacer.h")]
public partial class USpacer : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The size of the spacer</summary>
	public FVector2D Size;
	///<summary>Sets the size of the spacer</summary>
	public void SetSize(FVector2D InSize) {}
}
