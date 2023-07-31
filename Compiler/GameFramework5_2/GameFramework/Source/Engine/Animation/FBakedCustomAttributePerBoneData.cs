#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CustomAttributes.h")]
public partial struct FBakedCustomAttributePerBoneData {
	public int BoneTreeIndex;
	public TArray<FBakedStringCustomAttribute> StringAttributes;
	public TArray<FBakedIntegerCustomAttribute> IntAttributes;
	public TArray<FBakedFloatCustomAttribute> FloatAttributes;
}
