namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Plays different sounds depending on the number of active sounds</summary>
[CppInclude("Sound/SoundNodeGroupControl.h")]
public partial class USoundNodeGroupControl : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>How many active sounds are allowed for each group</summary>
	public TArray<int> GroupSizes;
}
