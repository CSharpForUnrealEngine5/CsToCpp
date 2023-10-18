namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendSpace.h")]
public partial struct FBlendParameter {
	public string DisplayName;
	public float Min;
	public float Max;
	public int GridNum;
	public bool bSnapToGrid;
	public bool bWrapInput;
}
