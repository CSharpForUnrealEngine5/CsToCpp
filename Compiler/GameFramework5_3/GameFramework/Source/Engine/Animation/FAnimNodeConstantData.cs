namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Any constant class data an anim node uses should be derived from this type.</summary>
[CppInclude("Animation/AnimNodeConstantData.h")]
public partial struct FAnimNodeConstantData {
	public object /*AnimClassInterface*/ AnimClassInterface;
	public int NodeIndex;
}
