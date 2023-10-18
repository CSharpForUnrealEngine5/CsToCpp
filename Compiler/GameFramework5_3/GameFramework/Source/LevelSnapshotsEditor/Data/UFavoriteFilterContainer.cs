namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps track of selected favorite filters.</summary>
[CppInclude("Data/FavoriteFilterContainer.h")]
public partial class UFavoriteFilterContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The filters the user selected to use.</summary>
	public TArray<UClass> Favorites;
}
