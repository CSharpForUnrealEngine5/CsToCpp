#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavRelevantComponent.h")]
public partial class UNavRelevantComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetNavigationRelevancy</summary>
	public  void SetNavigationRelevancy(bool bRelevant) {}
	///<summary>attach navigation data to entry for owner&#39;s root component (depends on its relevancy)</summary>
	public bool bAttachToOwnersRoot;
	///<summary>CachedNavParent</summary>
	public UObject CachedNavParent;
}
