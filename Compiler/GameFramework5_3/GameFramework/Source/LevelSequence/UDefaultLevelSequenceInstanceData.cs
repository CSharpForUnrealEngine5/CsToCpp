namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default instance data class that level sequences understand. Implements IMovieSceneTransformOrigin.</summary>
[CppInclude("DefaultLevelSequenceInstanceData.h")]
public partial class UDefaultLevelSequenceInstanceData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When set, this actor&#39;s world position will be used as the transform origin for all absolute transform sections</summary>
	public AActor TransformOriginActor;
	///<summary>Specifies a transform that offsets all absolute transform sections in this sequence. Scale is ignored. Not applied to Relative or Additive sections.</summary>
	public FTransform TransformOrigin;
}
