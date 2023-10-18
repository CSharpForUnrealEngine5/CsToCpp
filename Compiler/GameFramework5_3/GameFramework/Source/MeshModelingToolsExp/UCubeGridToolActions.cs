namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CubeGridTool.h")]
public partial class UCubeGridToolActions : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Can also be invoked with E.</summary>
	public void Pull() {}
	///<summary>Can also be invoked with Q.</summary>
	public void Push() {}
	///<summary>Can also be invoked with Shift + E.</summary>
	public void SlideBack() {}
	///<summary>Can also be invoked with Shift + Q.</summary>
	public void SlideForward() {}
	///<summary>Engages a mode where specific corners can be selected to push/pull only</summary>
	public void CornerMode() {}
	///<summary>Can also be invoked with T.</summary>
	public void Flip() {}
	///<summary>Actor whose transform to use when doing Reset Grid From Actor.</summary>
	public AActor GridSourceActor;
	///<summary>Resets the grid position and orientation based on the actor in Grid Source Actor. This allows</summary>
	public void ResetGridFromActor() {}
}
