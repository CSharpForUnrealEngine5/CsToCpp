namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the game-specific leaderboard name and corresponding ID from Google Play services.</summary>
[CppInclude("AndroidRuntimeSettings.h")]
public partial struct FGooglePlayLeaderboardMapping {
	public string Name;
	public string LeaderboardID;
}
