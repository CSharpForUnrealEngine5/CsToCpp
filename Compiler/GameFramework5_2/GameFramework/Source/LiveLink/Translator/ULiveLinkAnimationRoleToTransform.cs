namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Basic object to translate data from one role to another</summary>
[CppInclude("Translator/LiveLinkAnimationRoleToTransform.h")]
public partial class ULiveLinkAnimationRoleToTransform : ULiveLinkFrameTranslator {
	public static UClass StaticClass() {return default;}
	///<summary>BoneName</summary>
	public FName BoneName;
}
