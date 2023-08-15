namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pose in local space (i.e. each transform is relative to its parent)</summary>
[CppInclude("Animation/AnimationTypes.h")]
public partial struct FLocalSpacePose {
	public TArray<FTransform> Transforms;
	public TArray<FName> Names;
}
