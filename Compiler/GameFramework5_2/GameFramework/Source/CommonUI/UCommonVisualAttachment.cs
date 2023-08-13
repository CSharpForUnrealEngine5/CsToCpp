namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds a widget as a zero-size attachment to another. Think icons to the left of labels, without changing the computed size of the label.</summary>
[CppInclude("CommonVisualAttachment.h")]
public partial class UCommonVisualAttachment : USizeBox {
	public static UClass StaticClass() {return default;}
	///<summary>ContentAnchor</summary>
	public FVector2D ContentAnchor;
}
