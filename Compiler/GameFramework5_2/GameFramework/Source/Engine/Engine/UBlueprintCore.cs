#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BlueprintCore.h")]
public partial class UBlueprintCore : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the skeleton class; this is regenerated any time a member variable or function is added but</summary>
	public UClass SkeletonGeneratedClass;
	///<summary>Pointer to the &#39;most recent&#39; fully generated class</summary>
	public UClass GeneratedClass;
	///<summary>BackCompat:  Whether or not we need to purge references in this blueprint to the skeleton generated during compile-on-load</summary>
	public bool bLegacyNeedToPurgeSkelRefs;
	///<summary>Blueprint Guid</summary>
	public FGuid BlueprintGuid;
}
