#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BinkMediaPlayer.h")]
///<summary>Enumerates available bink buffering modes.</summary>
public enum EBinkMediaPlayerBinkDrawStyle {
	BMASM_Bink_DS_RenderToTexture=0,
	BMASM_Bink_DS_OverlayFillScreenWithAspectRatio=1,
	BMASM_Bink_DS_OverlayOriginalMovieSize=2,
	BMASM_Bink_DS_OverlayFillScreen=3,
	BMASM_Bink_DS_OverlaySpecificDestinationRectangle=4,
	BMASM_Bink_DS_MAX=5,
}
