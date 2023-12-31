namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>APaperCharacter behaves like ACharacter, but uses a UPaperFlipbookComponent instead of a USkeletalMeshComponent as a visual representation</summary>
[CppInclude("PaperCharacter.h")]
public partial class APaperCharacter : ACharacter {
	public static UClass StaticClass() {return default;}
	///<summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
	public UPaperFlipbookComponent Sprite;
}
