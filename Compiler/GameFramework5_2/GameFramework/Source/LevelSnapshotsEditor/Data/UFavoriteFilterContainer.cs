#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps track of selected favorite filters.</summary>
[CppInclude("Data/FavoriteFilterContainer.h")]
public partial class UFavoriteFilterContainer : UObject {
	///<summary>The filters the user selected to use.</summary>
	public TArray<UClass> Favorites;
}
