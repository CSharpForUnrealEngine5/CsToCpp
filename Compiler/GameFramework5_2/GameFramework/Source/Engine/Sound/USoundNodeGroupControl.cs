#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plays different sounds depending on the number of active sounds</summary>
[CppInclude("Sound/SoundNodeGroupControl.h")]
public partial class USoundNodeGroupControl : USoundNode {
	///<summary>How many active sounds are allowed for each group</summary>
	public TArray<int> GroupSizes;
}
