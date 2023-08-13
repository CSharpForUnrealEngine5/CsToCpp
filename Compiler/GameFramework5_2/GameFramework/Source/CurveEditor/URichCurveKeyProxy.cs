namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RichCurveKeyProxy.h")]
public partial class URichCurveKeyProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>User-facing value of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
	public FRichCurveKey Value;
}
