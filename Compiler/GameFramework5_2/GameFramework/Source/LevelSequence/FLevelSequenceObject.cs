#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceObject.h")]
///<summary>Structure for animated Actor objects.</summary>
public partial struct FLevelSequenceObject {
// LevelSequenceObject
	public TLazyObjectPtr<UObject> ObjectOrOwner;
	public string ComponentName;
	public TWeakObjectPtr<UObject> CachedComponent;
}
