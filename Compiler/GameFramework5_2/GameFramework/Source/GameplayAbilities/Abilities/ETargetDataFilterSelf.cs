namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetDataFilter.h")]
///<summary>Set rather it is possible to target self</summary>
[CppEnumInNamespace]
public enum ETargetDataFilterSelf {
	TDFS_Any=0,
	TDFS_NoSelf=1,
	TDFS_NoOthers=2,
}
