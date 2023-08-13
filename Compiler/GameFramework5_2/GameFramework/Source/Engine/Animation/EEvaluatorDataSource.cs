namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_TransitionPoseEvaluator.h")]
///<summary>Indicates which state is being evaluated by this node (source or destination).</summary>
[CppEnumInNamespace]
public enum EEvaluatorDataSource {
	EDS_SourcePose=0,
	EDS_DestinationPose=1,
}
