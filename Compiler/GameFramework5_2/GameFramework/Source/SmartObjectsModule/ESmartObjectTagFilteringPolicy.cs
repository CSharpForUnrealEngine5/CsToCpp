namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTypes.h")]
///<summary>Indicates how TagQueries from slots and parent object will be processed against Tags from a find request.</summary>
public enum ESmartObjectTagFilteringPolicy {
	NoFilter=0,
	Combine=1,
	Override=2,
}
