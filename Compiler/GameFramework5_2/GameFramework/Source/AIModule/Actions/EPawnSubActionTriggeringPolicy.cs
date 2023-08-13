namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction.h")]
[CppEnumInNamespace]
public enum EPawnSubActionTriggeringPolicy {
	CopyBeforeTriggering=0,
	ReuseInstances=1,
}
