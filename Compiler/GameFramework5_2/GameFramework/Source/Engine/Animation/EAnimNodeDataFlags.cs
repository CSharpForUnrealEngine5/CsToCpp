#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNodeData.h")]
///<summary>The flags field of FAnimNodeData</summary>
public enum EAnimNodeDataFlags {
	None=0,
	HasInitialUpdateFunction=1,
	HasBecomeRelevantFunction=2,
	HasUpdateFunction=4,
}
