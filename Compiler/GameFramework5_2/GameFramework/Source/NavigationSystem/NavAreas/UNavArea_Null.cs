namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>In general represents an empty area, that cannot be traversed by anyone. Ever.</summary>
[CppInclude("NavAreas/NavArea_Null.h")]
public partial class UNavArea_Null : UNavArea {
	public static UClass StaticClass() {return default;}
}
