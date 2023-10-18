namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A camera position the current level.</summary>
[CppInclude("Engine/BookMark.h")]
public partial class UBookMark : UBookmarkBase {
	public static UClass StaticClass() {return default;}
	///<summary>Camera position</summary>
	public FVector Location;
	///<summary>Camera rotation</summary>
	public FRotator Rotation;
	///<summary>Array of levels that are hidden</summary>
	public TArray<string> HiddenLevels;
}
