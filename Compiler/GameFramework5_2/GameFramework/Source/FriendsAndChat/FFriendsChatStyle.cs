#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interface for the services manager.</summary>
[CppInclude("FriendsChatStyle.h")]
public partial struct FFriendsChatStyle {
	public FTextBlockStyle TextStyle;
	public FTextBlockStyle TimeStampTextStyle;
	public float TimeStampOpacity;
	public FLinearColor DefaultChatColor;
	public FLinearColor WhisperChatColor;
	public FLinearColor GlobalChatColor;
	public FLinearColor FounderChatColor;
	public FLinearColor GameChatColor;
	public FLinearColor TeamChatColor;
	public FLinearColor PartyChatColor;
	public FLinearColor AdminChatColor;
	public FLinearColor GameAdminChatColor;
	public FLinearColor AddedItemChatColor;
	public FLinearColor CompletedItemChatColor;
	public FLinearColor DiscardedItemChatColor;
	public FLinearColor WhisperHyperlinkChatColor;
	public FLinearColor GlobalHyperlinkChatColor;
	public FLinearColor FounderHyperlinkChatColor;
	public FLinearColor GameHyperlinkChatColor;
	public FLinearColor TeamHyperlinkChatColor;
	public FLinearColor PartyHyperlinkChatColor;
	public FLinearColor EnemyColor;
	public FLinearColor FriendlyColor;
	public FEditableTextBoxStyle ChatEntryTextStyle;
	public FEditableTextBoxStyle ChatDisplayTextStyle;
	public FScrollBoxStyle ScrollBorderStyle;
	public FSlateBrush MessageNotificationBrush;
	public FMargin ChatEntryPadding;
	public float ChatEntryHeight;
	public FMargin FriendActionPadding;
	public FMargin FriendActionHeaderPadding;
	public FMargin FriendActionStatusMargin;
}
