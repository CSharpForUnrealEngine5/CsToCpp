namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is a singleton initialized from the ini</summary>
[CppInclude("Sound/SoundGroups.h")]
public partial class USoundGroups : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The ini editable array of profiles</summary>
	public TArray<FSoundGroup> SoundGroupProfiles;
}
