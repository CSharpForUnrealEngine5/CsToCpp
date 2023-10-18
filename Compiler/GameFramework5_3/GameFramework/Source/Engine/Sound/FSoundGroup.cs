namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundGroups.h")]
public partial struct FSoundGroup {
	public ESoundGroup SoundGroup;
	public string DisplayName;
	public bool bAlwaysDecompressOnLoad;
	public float DecompressedDuration;
}
