namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Float curve data for one track</summary>
[CppInclude("Animation/AnimCurveTypes.h")]
public partial struct FAnimCurveBase {
	public FName LastObservedName_DEPRECATED;
	public FSmartName Name;
	public FLinearColor Color;
	public int CurveTypeFlags;
}
