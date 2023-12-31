namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The runtime processor that converts an input pose from a source skeleton into an output pose on a target skeleton.</summary>
[CppInclude("Retargeter/IKRetargetProcessor.h")]
public partial class UIKRetargetProcessor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The IK Rig processor for running IK on the target // must be property to keep from being GC&#39;d</summary>
	public UIKRigProcessor IKRigProcessor;
}
