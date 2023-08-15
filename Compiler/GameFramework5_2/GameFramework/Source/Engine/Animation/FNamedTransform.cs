namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A named transform</summary>
[CppInclude("Animation/AnimationTypes.h")]
public partial struct FNamedTransform {
	public FTransform Value;
	public FName Name;
}
