using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace BlackListManager.BlackList
{
    public class BlackList
    {
        private string[] _lowercaseBlacklist;

        public void Initialize()
        {
            _lowercaseBlacklist = Config.BlackList
                .Select(x => x.ToLowerInvariant())
                .ToArray();
        }

        private void CheckAndKick(JoinedEventArgs ev)
        {
            Player player = ev.Player;
            string playerNickname = player.Nickname.ToLowerInvariant();
            
            if (_lowercaseBlacklist.Any(blacklisted => playerNickname.Contains(blacklisted)))
            {
                player.Kick("You have been kicked because your nickname is blacklisted.");
            }
        }
        
        public void Register()
        {
            Exiled.Events.Handlers.Player.Joined += CheckAndKick;
        }

        public void Unregister()
        {
            Exiled.Events.Handlers.Player.Joined -= CheckAndKick;
        }
    }
}