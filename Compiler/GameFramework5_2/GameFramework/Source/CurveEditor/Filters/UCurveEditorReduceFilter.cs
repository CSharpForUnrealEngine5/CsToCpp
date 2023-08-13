namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorReduceFilter.h")]
public partial class UCurveEditorReduceFilter : UCurveEditorFilterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum change in values required for a key to be considered distinct enough to keep.</summary>
	public float Tolerance;
	///<summary>Flag whether or not to use SampleRate for sampling between evaluated keys, which allows for removing user-tangent keys.</summary>
	public bool bTryRemoveUserSetTangentKeys;
	///<summary>Rate at which the curve should be sampled to compare against value tolerance.</summary>
	public FFrameRate SampleRate;
}
