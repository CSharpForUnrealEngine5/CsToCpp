#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationTypes.h")]
///<summary>A pose in component space (i.e. each transform is relative to the component's transform)</summary>
public partial struct FComponentSpacePose {
// ComponentSpacePose
	public TArray<FTransform> Transforms;
	public TArray<string> Names;
}
