#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>This submix class can be derived from for submixes that output to a parent submix.</summary>
public partial class USoundSubmixWithParentBase : USoundSubmixBase {
// SoundSubmixWithParentBase
	public USoundSubmixBase ParentSubmix;
}
