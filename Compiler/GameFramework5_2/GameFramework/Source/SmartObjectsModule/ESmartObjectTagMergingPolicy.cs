#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTypes.h")]
///<summary>Indicates how Tags from slots and parent object are combined to be evaluated by a TagQuery from a find request.</summary>
public enum ESmartObjectTagMergingPolicy {
	Combine=0,
	Override=1,
}
