namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Special area that can be generated in spaces with insufficient free height above. Cannot be traversed by anyone.</summary>
[CppInclude("NavAreas/NavArea_LowHeight.h")]
public partial class UNavArea_LowHeight : UNavArea {
	public static UClass StaticClass() {return default;}
}
