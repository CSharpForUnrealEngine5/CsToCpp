namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blend the top and bottom field, keeping temporal resolution but halving texture vertical resoluton.</summary>
[CppInclude("MediaIOCoreDeinterlacer.h")]
public partial class UBlendDeinterlacer : UVideoDeinterlacer {
	public static UClass StaticClass() {return default;}
}
