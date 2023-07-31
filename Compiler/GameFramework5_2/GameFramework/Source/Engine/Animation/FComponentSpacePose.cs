#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pose in component space (i.e. each transform is relative to the component&#39;s transform)</summary>
[CppInclude("Animation/AnimationTypes.h")]
public partial struct FComponentSpacePose {
	public TArray<FTransform> Transforms;
	public TArray<string> Names;
}
