#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is a singleton initialized from the ini</summary>
[CppInclude("Sound/SoundGroups.h")]
public partial class USoundGroups : UObject {
	///<summary>The ini editable array of profiles</summary>
	public TArray<FSoundGroup> SoundGroupProfiles;
}
