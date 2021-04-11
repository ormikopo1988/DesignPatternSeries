namespace Bridge.Problem
{
    /// <summary>
    /// Class hierarchy we are going to have for having various types of remote controls (like RemoteControl, AdvancedRemoteControl etc.)
    /// and also various brands for all those types (like Sony, Samsung etc.)
    /// RemoteControl
    ///     SonyRemoteControl
    ///     SamsungRemoteControl
    ///     AdvancedRemoteControl
    ///         SonyAdvancedRemoteControl
    ///         SamsungAdvancedRemoteControl
    /// 2 types of remote controls -> 2 new classes for every new brand we want to support
    /// If in the future we want to introduce a new type of remote control (e.g. MovieRemoteControl)
    /// then for every new brand we want to support we have to introduce 3 new classes (e.g. LgRemoteControl, LgAdvancedRemoteControl, LgMovieRemoteControl)
    /// Our hierarchy is growing in two dimensions (remote control type - Feature & brand type - Implementation) 
    /// That means that the object hierarchy will eventually become complex and not so flexibile and maintainable.
    /// </summary>
    public abstract class RemoteControl
    {
        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}
