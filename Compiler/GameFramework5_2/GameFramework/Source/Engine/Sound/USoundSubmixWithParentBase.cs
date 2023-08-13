namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This submix class can be derived from for submixes that output to a parent submix.</summary>
[CppInclude("Sound/SoundSubmix.h")]
public partial class USoundSubmixWithParentBase : USoundSubmixBase {
	public static UClass StaticClass() {return default;}
	///<summary>ParentSubmix</summary>
	public USoundSubmixBase ParentSubmix;
}
