namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing all information related to an LOD group and providing helper functions to calculate</summary>
[CppInclude("Engine/TextureLODSettings.h")]
public partial class UTextureLODSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of LOD settings with entries per group.</summary>
	public TArray<FTextureLODGroup> TextureLODGroups;
}
