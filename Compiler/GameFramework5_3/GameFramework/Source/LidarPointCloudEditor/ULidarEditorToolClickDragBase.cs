namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarEditorToolClickDragBase : ULidarEditorToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>ClickDragBehavior</summary>
	public UClickDragInputBehavior ClickDragBehavior;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
}
