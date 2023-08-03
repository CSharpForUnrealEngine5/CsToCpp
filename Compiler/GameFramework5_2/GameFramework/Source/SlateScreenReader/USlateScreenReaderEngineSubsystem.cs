#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The engine subsystem for the Slate screen reader.</summary>
[CppInclude("SlateScreenReaderEngineSubsystem.h")]
public partial class USlateScreenReaderEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Activates the underlying screen reader. Use this to allow screen reader users to register with the screen reader</summary>
	public  void ActivateScreenReader() {}
	///<summary>Deactivates the underlying screen reader and prevents screen reader users from getting</summary>
	public  void DeactivateScreenReader() {}
	///<summary>Returns true if the screen reader is currently active and accessibility services such as text to speech can be used by the screen reader users.</summary>
	public  bool IsScreenReaderActive() { return default; }
	///<summary>Activates a screen reader user and fulfill requests for accessibility services such as text to speech that clients can make.</summary>
	public  FScreenReaderReply ActivateUser(int InUserId) { return default; }
	///<summary>Deactivates the screen reader and disables all announcement and text to speech services</summary>
	public  FScreenReaderReply DeactivateUser(int InUserId) { return default; }
	///<summary>Registers a provided user Id to the screen reader framework and allows the screen reader user to receive and respond to accessible events and accessible input.</summary>
	public  FScreenReaderReply RegisterUser(int InUserId) { return default; }
	///<summary>Unregisters a provided user Id from the screen reader framework and deactivates the user. The unregistered user will no longer receive or respond to accessible events and input.</summary>
	public  FScreenReaderReply UnregisterUser(int InUserId) { return default; }
	///<summary>Returns true if the passed in screen reader user Id is already registered. Else false is returned.</summary>
	public  bool IsUserRegistered(int InUserId) { return default; }
	///<summary>Requests an announcement to be spoken to the screen reader user. This is the main mechanism to provide text to speech auditory feedback</summary>
	public  FScreenReaderReply RequestSpeak(int InUserId,FScreenReaderAnnouncement InAnnouncement) { return default; }
	///<summary>Requests the information about the accessibility widget a user is focused on to be read out.</summary>
	public  FScreenReaderReply RequestSpeakFocusedWidget(int InUserId) { return default; }
	///<summary>Immediately stops speaking any currently spoken announcement for a particular screen reader user.</summary>
	public  FScreenReaderReply StopSpeaking(int InUserId) { return default; }
	///<summary>Returns true if the screen reader is speaking text to a particular user.</summary>
	public  bool IsSpeaking(int InUserId) { return default; }
	///<summary>Returns the volume text to speech will be speaking at for a screen reader user.  Value is between 0.0f and 1.0f.</summary>
	public  float GetSpeechVolume(int InUserId) { return default; }
	///<summary>Sets the volume text to speech will be speaking at for a screen reader user.</summary>
	public  FScreenReaderReply SetSpeechVolume(int InUserId,float InVolume) { return default; }
	///<summary>Returns the rate text to speech will be speaking at for a screen reader user.  Value is between 0.0f and 1.0f.</summary>
	public  float GetSpeechRate(int InUserId) { return default; }
	///<summary>Sets the rate text to speech will be speaking at for a screen reader user.</summary>
	public  FScreenReaderReply SetSpeechRate(int InUserId,float InRate) { return default; }
	///<summary>Mutes the text to speech for a screen reader user.</summary>
	public  FScreenReaderReply MuteSpeech(int InUserId) { return default; }
	///<summary>Unmutes the text to speech for a screen reader user.</summary>
	public  FScreenReaderReply UnmuteSpeech(int InUserId) { return default; }
	///<summary>Returns true if text to speech for a screen reader user is muted. Otherwise false is returned.</summary>
	public  bool IsSpeechMuted(int InUserId) { return default; }
}
