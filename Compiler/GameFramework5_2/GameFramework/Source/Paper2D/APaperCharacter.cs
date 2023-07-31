#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>APaperCharacter behaves like ACharacter, but uses a UPaperFlipbookComponent instead of a USkeletalMeshComponent as a visual representation</summary>
[CppInclude("PaperCharacter.h")]
public partial class APaperCharacter : ACharacter {
	///<summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
	public UPaperFlipbookComponent Sprite;
}
