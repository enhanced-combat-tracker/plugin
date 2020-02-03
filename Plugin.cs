using System;
using System.Collections;

namespace EnhancedCombatTracker
{
    public abstract class Plugin
    {
        /// <summary>
        /// Query for plugin information. Assume that this is run at any time, including before Load or Initialize.
        /// </summary>
        public abstract PluginInformation Information;
        /// <summary>
        /// Query for plugin dependencies. Assume that this is run at any time, including before Load or Initialize.
        /// </summary>
        public abstract ICollection<PluginDependency> Dependencies;

        /// <summary>
        /// This will be run when your plugin is first loaded. Assume that no other plugins are loaded.
        /// </summary>
        public abstract void Load();
        /// <summary>
        /// This will be run after all plugins have had their <see cref="Load"/> method invoked. Assume that all other plugins have already been loaded.
        /// </summary>
        public abstract void Initialize();
    }
}
