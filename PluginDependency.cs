using System;

namespace EnhancedCombatTracker
{
    public class PluginDependency
    {
        public string AssemblyName;
        public Version Version;
        public DependencyType DependencyType;
    }

    public enum DependencyType
    {
        // Meaning that this plugin requires at least the version specified
        Minimum,
        // Meaning that the plugin requires at most the version specified
        Maximum
    }
}