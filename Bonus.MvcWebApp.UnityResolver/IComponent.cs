﻿namespace Bonus.MvcWebApp.UnityResolver
{
    /// <summary>
    /// Register underlying types with unity.
    /// </summary>
    public interface IComponent
    {
        void SetUp(IRegisterComponent registerComponent);
    }
}
