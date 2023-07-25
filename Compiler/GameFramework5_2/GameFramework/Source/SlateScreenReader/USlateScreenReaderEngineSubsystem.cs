#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SlateScreenReaderEngineSubsystem.h")]
///<summary>The engine subsystem for the Slate screen reader.</summary>
public partial class USlateScreenReaderEngineSubsystem : UEngineSubsystem {
// SlateScreenReaderEngineSubsystem
	public void ActivateScreenReader() {}
	public void DeactivateScreenReader() {}
	public bool IsScreenReaderActive() { return default; }
	public FScreenReaderReply ActivateUser(int InUserId) { return default; }
	public FScreenReaderReply DeactivateUser(int InUserId) { return default; }
	public FScreenReaderReply RegisterUser(int InUserId) { return default; }
	public FScreenReaderReply UnregisterUser(int InUserId) { return default; }
	public bool IsUserRegistered(int InUserId) { return default; }
	public FScreenReaderReply RequestSpeak(int InUserId,FScreenReaderAnnouncement InAnnouncement) { return default; }
	public FScreenReaderReply RequestSpeakFocusedWidget(int InUserId) { return default; }
	public FScreenReaderReply StopSpeaking(int InUserId) { return default; }
	public bool IsSpeaking(int InUserId) { return default; }
	public float GetSpeechVolume(int InUserId) { return default; }
	public FScreenReaderReply SetSpeechVolume(int InUserId,float InVolume) { return default; }
	public float GetSpeechRate(int InUserId) { return default; }
	public FScreenReaderReply SetSpeechRate(int InUserId,float InRate) { return default; }
	public FScreenReaderReply MuteSpeech(int InUserId) { return default; }
	public FScreenReaderReply UnmuteSpeech(int InUserId) { return default; }
	public bool IsSpeechMuted(int InUserId) { return default; }
}
