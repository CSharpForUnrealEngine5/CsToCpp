#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationTypes.h")]
///<summary>A pose in local space (i.e. each transform is relative to its parent)</summary>
public partial struct FLocalSpacePose {
// LocalSpacePose
	public TArray<FTransform> Transforms;
	public TArray<string> Names;
}
