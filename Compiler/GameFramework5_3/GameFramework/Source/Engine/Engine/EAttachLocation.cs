namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Deprecated rules for setting transform on attachment, new functions should use FAttachmentTransformRules isntead</summary>
[CppEnumInNamespace]
public enum EAttachLocation {
	KeepRelativeOffset=0,
	KeepWorldPosition=1,
	SnapToTarget=2,
	SnapToTargetIncludingScale=3,
}
