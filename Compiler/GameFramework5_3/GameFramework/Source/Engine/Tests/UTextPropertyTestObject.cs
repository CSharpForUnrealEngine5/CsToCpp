namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/TextPropertyTestObject.h")]
public partial class UTextPropertyTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultedText</summary>
	public FText DefaultedText;
	///<summary>UndefaultedText</summary>
	public FText UndefaultedText;
	///<summary>TransientText</summary>
	public FText TransientText;
}
