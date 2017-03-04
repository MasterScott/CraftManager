
using PoeHUD.Poe;
using PoeHUD.Plugins;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using System.Threading;
using SharpDX;

namespace CraftManager
{
    public class CMCore : BaseSettingsPlugin<CMSettings>
    {
        private Element CurInventRoot = null;
        private readonly int logmsg_time = 1;
        private readonly int errmsg_time = 1;
        private InventoryItemIcon CurrentHoverItem;
        private bool IsInTown;
        private bool IsInHideout;

        public override void Render()
        {
            base.Render();
            if (!GameController.Game.IngameState.IngameUi.OpenLeftPanel.IsVisible)
                return;

            CurrentHoverItem = GameController.Game.IngameState.UIHover.AsObject<InventoryItemIcon>();

            if (CurrentHoverItem.ToolTipType == ToolTipType.InventoryItem && CurrentHoverItem.Item != null)
            {
                CurInventRoot = CurrentHoverItem.Parent.Parent;
                Graphics.DrawBox(CurrentHoverItem.Parent.GetClientRect(), Color.Yellow);
            }
            return;
        }
        public override void Initialise()
        {
            base.Initialise();
            PluginName = "Craft Manager";
            GameController.Area.OnAreaChange += area => OnAreaChange(area);
            Settings.Enable.OnValueChanged += OnCMToggle;
            OnCMToggle();
            return;
        }
        private void OnAreaChange(AreaController area)
        {
            IsInHideout = area.CurrentArea.IsHideout;
            IsInTown = area.CurrentArea.IsTown;
        }
        private void OnCMToggle()
        {
            if ( Settings.Enable.Value)
            {
                IsInHideout = false;
                IsInTown = false;
                Thread cmThread = new Thread(CMThread) { IsBackground = true };
                cmThread.Start();
            }
        }
        private void CMThread()
        {
            while (Settings.Enable.Value)
            {
                Thread.Sleep(1000);
                if (CurInventRoot == null || !(IsInTown || IsInHideout) || !GameController.Game.IngameState.IngameUi.OpenLeftPanel.IsVisible)
                {
                    LogError("Person isn't in Town/Hideout or stash isn't opened.", errmsg_time);
                    continue;
                }
                LogMessage(CurrentHoverItem.X + "," + CurrentHoverItem.Y, logmsg_time);
            }
            LogMessage("Turning off Crafting Manager.", logmsg_time);
        }
    }
}
