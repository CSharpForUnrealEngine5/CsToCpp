namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that provides a directional wind source. Only affects SpeedTree assets.</summary>
[CppInclude("Engine/WindDirectionalSource.h")]
public partial class AWindDirectionalSource : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>Component</summary>
	public UWindDirectionalSourceComponent Component;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
}
