#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundGroups.h")]
public partial struct FSoundGroup {
	public ESoundGroup SoundGroup;
	public string DisplayName;
	public bool bAlwaysDecompressOnLoad;
	public float DecompressedDuration;
}
