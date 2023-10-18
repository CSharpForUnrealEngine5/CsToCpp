namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Safe-Zone widget is an essential part of developing a game UI that can run on lots of different non-PC platforms.</summary>
[CppInclude("Components/SafeZone.h")]
public partial class USafeZone : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetSidesToPad</summary>
	public void SetSidesToPad(bool InPadLeft,bool InPadRight,bool InPadTop,bool InPadBottom) {}
	///<summary>If this safe zone should pad for the left side of the screen&#39;s safe zone</summary>
	public bool PadLeft;
	///<summary>If this safe zone should pad for the right side of the screen&#39;s safe zone</summary>
	public bool PadRight;
	///<summary>If this safe zone should pad for the top side of the screen&#39;s safe zone</summary>
	public bool PadTop;
	///<summary>If this safe zone should pad for the bottom side of the screen&#39;s safe zone</summary>
	public bool PadBottom;
}
