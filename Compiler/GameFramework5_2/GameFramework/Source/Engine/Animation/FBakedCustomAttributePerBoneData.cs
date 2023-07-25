#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CustomAttributes.h")]
public partial struct FBakedCustomAttributePerBoneData {
// BakedCustomAttributePerBoneData
	public int BoneTreeIndex;
	public TArray<FBakedStringCustomAttribute> StringAttributes;
	public TArray<FBakedIntegerCustomAttribute> IntAttributes;
	public TArray<FBakedFloatCustomAttribute> FloatAttributes;
}
