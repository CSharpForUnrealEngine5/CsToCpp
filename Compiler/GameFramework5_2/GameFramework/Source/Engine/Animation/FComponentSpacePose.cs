namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pose in component space (i.e. each transform is relative to the component&#39;s transform)</summary>
[CppInclude("Animation/AnimationTypes.h")]
public partial struct FComponentSpacePose {
	public TArray<FTransform> Transforms;
	public TArray<string> Names;
}
