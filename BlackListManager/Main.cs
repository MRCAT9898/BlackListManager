using System;
using Exiled.API.Features;
using UnityEngine;

namespace BlackListManager
{
    public class Main : Plugin<Config>
    {
        public override string Name { get; } = "BlackListManager";
        public override string Author { get; } = "Mr.Cat";
        public override string Prefix { get; } = "BlackListManager";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(9, 8, 1);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Log.Info("BlackListManager Enabled.");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Log.Info("BlackListManager Disabled.");
        }
        
    }
}