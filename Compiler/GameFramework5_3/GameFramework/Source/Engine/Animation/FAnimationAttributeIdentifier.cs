namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-friendly structure for identifying an attribute (curve).</summary>
[CppInclude("Animation/AnimData/AttributeIdentifier.h")]
public partial struct FAnimationAttributeIdentifier {
	public FName Name;
	public FName BoneName;
	public int BoneIndex;
	public UScriptStruct ScriptStruct;
	public FSoftObjectPath ScriptStructPath;
}
