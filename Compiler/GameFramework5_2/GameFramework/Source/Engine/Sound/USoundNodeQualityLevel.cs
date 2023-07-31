#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This SoundNode uses GameUserSettings AudioQualityLevel (or the editor override) to choose which branch to play</summary>
[CppInclude("Sound/SoundNodeQualityLevel.h")]
public partial class USoundNodeQualityLevel : USoundNode {
	///<summary>A Property to indicate which quality this node was cooked with. (INDEX_NONE if not cooked, or unset).</summary>
	public int CookedQualityLevelIndex;
}
