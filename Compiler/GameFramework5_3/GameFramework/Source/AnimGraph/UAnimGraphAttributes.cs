namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphAttributes.h")]
public partial class UAnimGraphAttributes : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>All attributes</summary>
	public TArray<FAnimGraphAttributeDesc> Attributes;
}
