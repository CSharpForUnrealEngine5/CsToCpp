namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Ticking method for AnimNotifies in AnimMontages.</summary>
[CppEnumInNamespace]
public enum EMontageNotifyTickType {
	Queued=0,
	BranchingPoint=1,
}
