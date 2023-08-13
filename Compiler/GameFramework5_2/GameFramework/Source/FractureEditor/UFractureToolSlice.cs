namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolSlice.h")]
public partial class UFractureToolSlice : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Slicing</summary>
	public UFractureSliceSettings SliceSettings;
}
