namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blend List by Enum, it changes based on enum input that enters</summary>
[CppInclude("AnimNodes/AnimNode_BlendListByEnum.h")]
public partial struct FAnimNode_BlendListByEnum {
	public TArray<int> EnumToPoseIndex;
	public byte ActiveEnumValue;
}
