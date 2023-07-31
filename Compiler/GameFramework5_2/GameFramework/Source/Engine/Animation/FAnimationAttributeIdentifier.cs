#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-friendly structure for identifying an attribute (curve).</summary>
[CppInclude("Animation/AnimData/AttributeIdentifier.h")]
public partial struct FAnimationAttributeIdentifier {
	public string Name;
	public string BoneName;
	public int BoneIndex;
	public UScriptStruct ScriptStruct;
	public FSoftObjectPath ScriptStructPath;
}
