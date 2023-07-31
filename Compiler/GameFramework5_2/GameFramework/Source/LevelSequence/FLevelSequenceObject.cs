#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for animated Actor objects.</summary>
[CppInclude("LevelSequenceObject.h")]
public partial struct FLevelSequenceObject {
	public TLazyObjectPtr<UObject> ObjectOrOwner;
	public string ComponentName;
	public TWeakObjectPtr<UObject> CachedComponent;
}
