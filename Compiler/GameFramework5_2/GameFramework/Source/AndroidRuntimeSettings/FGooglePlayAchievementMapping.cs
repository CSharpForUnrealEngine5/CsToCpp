namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the game-specific achievement name and corresponding ID from Google Play services.</summary>
[CppInclude("AndroidRuntimeSettings.h")]
public partial struct FGooglePlayAchievementMapping {
	public string Name;
	public string AchievementID;
}
