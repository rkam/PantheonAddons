using PantheonAddonFramework.Models;

namespace PantheonAddonFramework.Events;

public interface IChatEvents
{
    AddonEvent<ChatMessage> OnMessageReceived { get; }
}