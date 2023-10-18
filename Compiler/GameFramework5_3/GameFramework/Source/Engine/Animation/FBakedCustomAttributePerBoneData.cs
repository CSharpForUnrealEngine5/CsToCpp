namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CustomAttributes.h")]
public partial struct FBakedCustomAttributePerBoneData {
	public int BoneTreeIndex;
	public TArray<FBakedStringCustomAttribute> StringAttributes;
	public TArray<FBakedIntegerCustomAttribute> IntAttributes;
	public TArray<FBakedFloatCustomAttribute> FloatAttributes;
}
