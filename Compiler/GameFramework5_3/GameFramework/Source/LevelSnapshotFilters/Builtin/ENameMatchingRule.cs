namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/PropertyHasNameFilter.h")]
[CppEnumInNamespace]
public enum ENameMatchingRule {
	MatchesExactly=0,
	MatchesIgnoreCase=1,
	ContainsExactly=2,
	ContainsIgnoreCase=3,
}
