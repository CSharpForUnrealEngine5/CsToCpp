#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SafeZone.h")]
///<summary>The Safe-Zone widget is an essential part of developing a game UI that can run on lots of different non-PC platforms.</summary>
public partial class USafeZone : UContentWidget {
// SafeZone
	public void SetSidesToPad(bool InPadLeft,bool InPadRight,bool InPadTop,bool InPadBottom) {}
	public bool PadLeft;
	public bool PadRight;
	public bool PadTop;
	public bool PadBottom;
}
